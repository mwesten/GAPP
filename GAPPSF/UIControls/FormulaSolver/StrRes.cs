﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAPPSF.UIControls.FormulaSolver
{
    public class StrRes
    {
        public static string STR_MISSING_ARGUMENT = "{0}: Argument missing. (Min. {1})";
        public static string STR_TO_MUCH_ARGUMENTS = "{0}: To much arguments. (Max. {1})";
        public static string STR_VALUE_OUT_OF_RANGE = "{0}: Value out of range. ({1} - {2})";
        public static string STR_BAD_PARAMETER_VALUE = "{0}: Bad parameter value";
        public static string STR_NO_CROSSING = "No crossing";
        public static string STR_MAX_1000_DIGITS = "Pi: Maximum digits: 1000";
        public static string STR_MIN_0_DIGITS = "Pi: Argument out of range: (0 - 1000)";
        public static string STR_UNKNOWN_FUNCTION = "Unknown function: ";
        public static string STR_MISSING_VARIABLES = "Insert declarations for the missing variables:\n{0}";
        public static string STR_INSERT_FORMULA = "Insert Formula";
        public static string STR_INSERT_WAYPOINT = "Insert Waypoint";
        public static string STR_SOLVE = "Solve";
        public static string STR_AS_WAYPOINT = "As Waypoint";
        public static string STR_AS_CENTER = "As Center";
        public static string STR_NUMBER_GROUP = "Number Functions";
        public static string STR_COORDINATE_GROUP = "Coordinate Functions";
        public static string STR_TEXT_GROUP = "Text Functions";
        public static string STR_UNKNOWN_GROUP = "Unknown Function Group";
        public static string STR_DESCR_CROSSTOTAL = "Sum of all single numbers in the parameter.\r\nExample: CT(654321) = 21";
        public static string STR_DESCR_ICROSSTOTAL = "Iterated Crosstotal until result has only 1 digit.\r\nExample: ICT(123456) = 3";
        public static string STR_DESCR_CROSSPRODUCT = "Product of all single numbers in the number.\r\nExample: CP(1234) = 24";
        public static string STR_DESCR_ICROSSPRODUCT = "Iterated Crossproduct until result has only 1 digit.\r\nExample: ICP(1234) = 8";
        public static string STR_DESCR_PRIMENUMBER = "Primenumber(x) Gives the x-th prime number.\r\nExample: Primenumber(5) = 11";
        public static string STR_DESCR_PRIMEINDEX = "PrimeIndex(y) Gives the index of the prime number y.\r\nExample: PrimeIndex(11) = 5";
        public static string STR_DESCR_INT = "Gives the number before the decimal point\r\nInt(-5.8) = -5";
        public static string STR_DESCR_ROUND = "Rounds the number to x digits\r\nRound(1.8672; 2) = 1.87";
        public static string STR_DESCR_ROM2DEC = "Roman numerals to decimal";
        public static string STR_DESCR_PI = "Gives the number Pi with n digits after decimal point\r\nPi(4) = 3.1415";
        public static string STR_DESCR_BEARING = "Gives the bearing from coord1 to coord2\r\nBearing(coord1; coord2)";
        public static string STR_DESCR_DISTANCE = "Gives the distance between coord1 and coord2 in meters\r\nDistance(coord1; coord2)";
        public static string STR_DESCR_CROSSBEARING = "Crossbearing between 2 points and 2 directions\r\nCrossbearing(coord1; angle1; coord2; angle2)";
        public static string STR_DESCR_INTERSECTION = "Intersection of 2 Lines (coord1-coord2) with (coord3-coord4).\r\nIntersection(coord1; coord2; coord3; coord4)";
        public static string STR_DESCR_PROJECTION = "Projection of Coordinate.\r\nProjection(coord; length; angle)";
        public static string STR_DESCR_ALPHASUM = "Sum of the positions of all characters in the alphabet";
        public static string STR_DESCR_ALPHAPOS = "Position of the first character in the alphabet";
        public static string STR_DESCR_PHONECODE = "Position of the first character on the phone keyboard";
        public static string STR_DESCR_PHONESUM = "Sum of the positions of all characters on the phone keyboard";
        public static string STR_DESCR_LEN = "Numbers of characters in the string";
        public static string STR_DESCR_MID = "Return a substring of a string. Parameter 3: Default=1\r\nMid(\"String\";StartPosition;[CharacterCount])";
        public static string STR_DESCR_REVERSE = "Reverses the string\r\nReverse(\"ABC\") = CBA";
        public static string STR_DESCR_ROT13 = "Gives the Rot13 encryption\r\nRot13(\"ABC\") = NOP";
        public static string STR_DESCR_WAYPOINT = "Get coordinates of a geocache waypoint by its name.\r\nWaypoint(\"FN2Y73E\") = \"N 51° 12.345 E 006° 43.210\"\r\nNo param gives cache coordinates.";
        public static string STR_WPSEL_TITLE = "Select Waypoint";
        public static string STR_WPSEL_WAYPOINTS = "Waypoints";
        public static string STR_WPSEL_INSERT = "Insert";
        public static string STR_WPSEL_CANCEL = "Cancel";
        public static string STR_INSFORM_TITLE = "Insert Formula";
        public static string STR_INSFORM_GROUP = "Group";
        public static string STR_INSFORM_FUNCTIONS = "Functions";
        public static string STR_INSFORM_OTHER = "Other Names";
        public static string STR_INSFORM_DESCRIPTION = "Description";
        public static string STR_INSFORM_INSERT = "Insert";
        public static string STR_INSFORM_CANCEL = "Cancel";
        public static string STR_DIV_BY_ZERO = "Division by zero";
        public static string STR_DESCR_POW = "Compute the power of the first to the second parameter\r\nPow(2;10) = 1024";
        public static string STR_DESCR_FACTORIAL = "Compute the factorial of an integer.\r\nFact(10) = 3628800";
        public static string STR_NO_CACHE_SELECTED = "No cache selected. (Quicknotes)";
        public static string NO_PROPER_COORDINATES_SELECTED = "No proper coordinate string selected.\r\nPlease select a complete coordinate string and try again.";
        public static string STR_DESCR_LATITUDE = "Gets the latitude from a coordinate as decimal number.\r\nLatitude(\"N 51° 12.081 E 6° 50.328\") = 51.20135";
        public static string STR_DESCR_LONGITUDE = "Gets the latitude from a coordinate as decimal number.\r\nLongitude(\"N 51° 12.081 E 6° 50.328\") = 6.8388";
        public static string STR_CONTEXT_GROUP = "Execution context functions";
        public static string STR_DESCR_CONTEXT = "Set options of execution context.\r\nSetContext(\"Rad\")";
        public static string STR_TRIGONOMETRIC_GROUP = "Trigonometric functions";
        public static string STR_DESC_SIN = "Trigonometric function Sine";
        public static string STR_DESC_COS = "Trigonometric function Cosine";
        public static string STR_DESC_TAN = "Trigonometric function Tangent";
        public static string STR_DESC_SINH = "Trigonometric function Hyperbolic Sine";
        public static string STR_DESC_COSH = "Trigonometric function Hyperbolic Cosine";
        public static string STR_DESC_TANH = "Trigonometric function Hyperbolic Tangent";
        public static string STR_DESC_ASIN = "Trigonometric function Inverse Sine";
        public static string STR_DESC_ACOS = "Trigonometric function Inverse Cosine";
        public static string STR_DESC_ATAN = "Trigonometric function Inverse Tangent";

        public static string GetString(string res)
        {
            return Localization.TranslationManager.Instance.Translate(res) as string;
        }
    }
}
