﻿using System;
using System.Windows.Controls;

namespace s3piwrappers.AnimatedTextureEditor.Validation
{
    class DecimalValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                Double.Parse((String)value);
            }
            catch (Exception)
            {
                return new ValidationResult(false, "*");
            }
            return new ValidationResult(true, null);

        }
    }
}