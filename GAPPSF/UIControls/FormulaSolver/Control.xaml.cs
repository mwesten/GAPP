﻿using GAPPSF.UIControls.FormulaSolver.FormulaInterpreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GAPPSF.UIControls.FormulaSolver
{
    /// <summary>
    /// Interaction logic for Control.xaml
    /// </summary>
    public partial class Control : UserControl, IUIControl, INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private FormulaInterpreter.FormulaInterpreter _interpreter;

        private Core.Data.Geocache _currentGeocache = null;
        public Core.Data.Geocache CurrentGeocache
        {
            get { return _currentGeocache; }
            set 
            {
                saveData();
                SetProperty(ref _currentGeocache, value);
                UpdateView();
            }
        }

        public Control()
        {
            using (var strm = Assembly.GetExecutingAssembly().GetManifestResourceStream("GAPPSF.UIControls.FormulaSolver.Grammar.SingleLineFormula.egt"))
            using (System.IO.BinaryReader br = new System.IO.BinaryReader(strm))
            {
                _interpreter = new FormulaInterpreter.FormulaInterpreter(br);
            }

            InitializeComponent();

            DataContext = this;

            Core.ApplicationData.Instance.PropertyChanged += Instance_PropertyChanged;

            //prevent saving
            _currentGeocache = Core.ApplicationData.Instance.ActiveGeocache;
            UpdateView();
        }

        void Instance_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName=="ActiveGeocache")
            {
                CurrentGeocache = Core.ApplicationData.Instance.ActiveGeocache;
            }
        }

        public void Dispose()
        {
            Core.ApplicationData.Instance.PropertyChanged -= Instance_PropertyChanged;
        }

        private void UpdateView()
        {
            tbSolutions.Text = "";
            if (_currentGeocache != null)
            {
                tbFormula.Text = Core.Settings.Default.GetFormula(_currentGeocache.Code) ?? "";
            }
            else
            {
                tbFormula.Text = Core.Settings.Default.GetFormula("NOTE") ?? "";
            }
        }

        private void saveData()
        {
            if (_currentGeocache != null)
            {
                Core.Settings.Default.SetFormula(_currentGeocache.Code, tbFormula.Text);
            }
            else
            {
                Core.Settings.Default.SetFormula("NOTE", tbFormula.Text);
            }
        }

        public override string ToString()
        {
            return Localization.TranslationManager.Instance.Translate("FormulaSolver") as string;
        }

        protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string name = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                var handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }
        }

        public int WindowWidth
        {
            get
            {
                return Core.Settings.Default.FormulaSolverWindowWidth;
            }
            set
            {
                Core.Settings.Default.FormulaSolverWindowWidth = value;
            }
        }

        public int WindowHeight
        {
            get
            {
                return Core.Settings.Default.FormulaSolverWindowHeight;
            }
            set
            {
                Core.Settings.Default.FormulaSolverWindowHeight = value;
            }
        }

        public int WindowLeft
        {
            get
            {
                return Core.Settings.Default.FormulaSolverWindowLeft;
            }
            set
            {
                Core.Settings.Default.FormulaSolverWindowLeft = value;
            }
        }

        public int WindowTop
        {
            get
            {
                return Core.Settings.Default.FormulaSolverWindowTop;
            }
            set
            {
                Core.Settings.Default.FormulaSolverWindowTop = value;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            saveData();

            String formula = tbFormula.Text;
            tbSolutions.Text = "";
            if (formula.Length > 0)
            {
                string[] lines = formula.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                StringBuilder sb = new StringBuilder();
                ExecutionContext ctx = new ExecutionContext();

                foreach (string line in lines)
                {
                    if (line.Length == 0)
                    {
                        sb.AppendLine("");
                    }
                    else
                    {
                        string res = Convert.ToString(_interpreter.Exec(line, ctx), new System.Globalization.CultureInfo(""));
                        sb.AppendLine(res);
                    }
                }

                if (ctx.HasMissingVariables())
                {
                    string text = string.Format(StrRes.GetString(StrRes.STR_MISSING_VARIABLES), String.Join(", ", ctx.GetMissingVariableNames()));
                    //if (MessageBox.Show(text, "Formula Solver", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        StringBuilder sbInput = new StringBuilder();
                        foreach (string name in ctx.GetMissingVariableNames())
                        {
                            sbInput.AppendLine(name + "=");
                        }
                        foreach (string line in lines)
                        {
                            sbInput.AppendLine(line);
                        }

                        tbFormula.Text = sbInput.ToString();
                    }
                    sb.Clear();
                }
                tbSolutions.Text = sb.ToString();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InsertFormulaWindow dlg = new InsertFormulaWindow();
            if (dlg.ShowDialog()==true)
            {
                UpdateFormulaText(dlg.SelectedFunction, -1);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WaypointSelectorWindow dlg = new WaypointSelectorWindow();
            if (dlg.ShowDialog()==true)
            {
                UpdateFormulaText(string.Format("WP(\"{0}\")", dlg.SelectedWaypoint.Code), 0);
            }
        }

        private void UpdateFormulaText(string txt, int moveCursorTo)
        {
            tbFormula.Focus();
            var selectionIndex = tbFormula.SelectionStart;
            tbFormula.Text = tbFormula.Text.Insert(selectionIndex, txt);
            tbFormula.SelectionStart = selectionIndex + Math.Max(0, txt.Length + moveCursorTo);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //not implemented yet
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Core.Data.Location ll = null;
            if (tbSolutions.SelectionLength > 0)
            {
                ll = Utils.Conversion.StringToLocation(tbSolutions.SelectedText);
            }
            if (ll != null)
            {
                Utils.DataAccess.SetCenterLocation(ll.Lat, ll.Lon);
            }
            else
            {
                Core.ApplicationData.Instance.Logger.AddLog(this, Core.Logger.Level.Error, StrRes.GetString(StrRes.NO_PROPER_COORDINATES_SELECTED));
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            UserHelpWindow dlg = new UserHelpWindow();
            dlg.ShowDialog();
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            saveData();
        }


    }
}
