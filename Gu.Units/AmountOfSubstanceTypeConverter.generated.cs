#nullable enable
namespace Gu.Units
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Design.Serialization;
    using System.Globalization;
    using System.Reflection;

    /// <summary>
    /// Provides a unified way of converting types of values to other types, as well as for accessing standard values and sub properties.
    /// </summary>
    /// <devdoc>
    /// <para>Provides a type converter to convert <see cref='Gu.Units.AmountOfSubstance'/>
    /// objects to and from various
    /// other representations.</para>
    /// </devdoc>
    public class AmountOfSubstanceTypeConverter : TypeConverter
    {
        /// <inheritdoc />
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        /// <inheritdoc />
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(InstanceDescriptor) || destinationType == typeof(string))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        /// <inheritdoc />
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var text = value as string;
            if (text != null)
            {
                return AmountOfSubstance.Parse(text, culture);
            }

            return base.ConvertFrom(context, culture, value);
        }

        /// <inheritdoc />
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is AmountOfSubstance && destinationType != null)
            {
                var amountOfSubstance = (AmountOfSubstance)value;
                if (destinationType == typeof(string))
                {
                    return amountOfSubstance.ToString(culture);
                }
                else if (destinationType == typeof(InstanceDescriptor))
                {
                    var factoryMethod = typeof(AmountOfSubstance).GetMethod(nameof(AmountOfSubstance.FromMoles), BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(double) }, null);
                    if (factoryMethod != null)
                    {
                        var args = new object[] { amountOfSubstance.moles };
                        return new InstanceDescriptor(factoryMethod, args);
                    }
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
