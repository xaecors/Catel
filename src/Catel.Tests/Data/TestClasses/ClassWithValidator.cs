﻿namespace Catel.Tests.Data
{
    using Catel.Data;

    /// <summary>
    /// ClassWithValidator Data object class which fully supports serialization, property changed notifications,
    /// backwards compatibility and error checking.
    /// </summary>
    public class ClassWithValidator : ValidatableModelBase
    {
        /// <summary>
        /// Gets or sets the warning property.
        /// </summary>
        public string WarningProperty
        {
            get { return GetValue<string>(WarningPropertyProperty); }
            set { SetValue(WarningPropertyProperty, value); }
        }

        /// <summary>
        /// Register the WarningProperty property so it is known in the class.
        /// </summary>
        public static readonly IPropertyData WarningPropertyProperty = RegisterProperty<string>("WarningProperty", string.Empty);

        /// <summary>
        /// Gets or sets the error property.
        /// </summary>
        public string ErrorProperty
        {
            get { return GetValue<string>(ErrorPropertyProperty); }
            set { SetValue(ErrorPropertyProperty, value); }
        }

        /// <summary>
        /// Register the ErrorProperty property so it is known in the class.
        /// </summary>
        public static readonly IPropertyData ErrorPropertyProperty = RegisterProperty<string>("ErrorProperty", string.Empty);

        /// <summary>
        /// Gets or sets the business rule error.
        /// </summary>
        public string BusinessRuleError
        {
            get { return GetValue<string>(BusinessRuleErrorProperty); }
            set { SetValue(BusinessRuleErrorProperty, value); }
        }

        /// <summary>
        /// Register the BusinessRuleError property so it is known in the class.
        /// </summary>
        public static readonly IPropertyData BusinessRuleErrorProperty = RegisterProperty<string>("BusinessRuleError", string.Empty);
    }
}
