#nullable enable
namespace Gu.Units
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    /// A type for the quantity <see cref="Gu.Units.Acceleration"/>.
    /// </summary>
    [TypeConverter(typeof(AccelerationTypeConverter))]
    [Serializable]
    public partial struct Acceleration : IQuantity<AccelerationUnit>, IComparable<Acceleration>, IEquatable<Acceleration>, IXmlSerializable
    {
        /// <summary>
        /// Gets a value that is zero <see cref="Gu.Units.AccelerationUnit.MetresPerSecondSquared"/>
        /// </summary>
        public static readonly Acceleration Zero = default(Acceleration);

#pragma warning disable SA1307 // Accessible fields must begin with upper-case letter
#pragma warning disable SA1304 // Non-private readonly fields must begin with upper-case letter
        /// <summary>
        /// The quantity in <see cref="Gu.Units.AccelerationUnit.MetresPerSecondSquared"/>.
        /// </summary>
        internal readonly double metresPerSecondSquared;
#pragma warning restore SA1304 // Non-private readonly fields must begin with upper-case letter
#pragma warning restore SA1307 // Accessible fields must begin with upper-case letter

        /// <summary>
        /// Initializes a new instance of the <see cref="Gu.Units.Acceleration"/> struct.
        /// </summary>
        /// <param name="value">The scalar value.</param>
        /// <param name="unit"><see cref="Gu.Units.AccelerationUnit"/>.</param>
        public Acceleration(double value, AccelerationUnit unit)
        {
            this.metresPerSecondSquared = unit.ToSiUnit(value);
        }

        private Acceleration(double metresPerSecondSquared)
        {
            this.metresPerSecondSquared = metresPerSecondSquared;
        }

        /// <summary>
        /// Gets the quantity in <see cref="Gu.Units.AccelerationUnit.MetresPerSecondSquared"/>
        /// </summary>
        public double SiValue => this.metresPerSecondSquared;

        /// <summary>
        /// Gets the <see cref="Gu.Units.AccelerationUnit"/> for the <see cref="SiValue"/>
        /// </summary>
        public AccelerationUnit SiUnit => AccelerationUnit.MetresPerSecondSquared;

        /// <summary>
        /// Gets the <see cref="Gu.Units.IUnit"/> for the <see cref="SiValue"/>
        /// </summary>
        IUnit IQuantity.SiUnit => AccelerationUnit.MetresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in metresPerSecondSquared".
        /// </summary>
        public double MetresPerSecondSquared => this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in CentimetresPerSecondSquared
        /// </summary>
        public double CentimetresPerSecondSquared => 100 * this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in MillimetresPerSecondSquared
        /// </summary>
        public double MillimetresPerSecondSquared => 1000 * this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in MillimetresPerHourSquared
        /// </summary>
        public double MillimetresPerHourSquared => 12960000000 * this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in CentimetresPerHourSquared
        /// </summary>
        public double CentimetresPerHourSquared => 1296000000 * this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in MetresPerHourSquared
        /// </summary>
        public double MetresPerHourSquared => 12960000 * this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in MetresPerMinuteSquared
        /// </summary>
        public double MetresPerMinuteSquared => 3600 * this.metresPerSecondSquared;

        /// <summary>
        /// Gets the quantity in MillimetresPerMinuteSquared
        /// </summary>
        public double MillimetresPerMinuteSquared => 3600000 * this.metresPerSecondSquared;

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Force"/> that is the result from the multiplication.</returns>
        public static Force operator *(Acceleration left, Mass right)
        {
            return Force.FromNewtons(left.metresPerSecondSquared * right.kilograms);
        }

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="SpecificEnergy"/> that is the result from the multiplication.</returns>
        public static SpecificEnergy operator *(Acceleration left, Length right)
        {
            return SpecificEnergy.FromJoulesPerKilogram(left.metresPerSecondSquared * right.metres);
        }

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Speed"/> that is the result from the multiplication.</returns>
        public static Speed operator *(Acceleration left, Time right)
        {
            return Speed.FromMetresPerSecond(left.metresPerSecondSquared * right.seconds);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Jerk"/> that is the result from the division.</returns>
        public static Jerk operator /(Acceleration left, Time right)
        {
            return Jerk.FromMetresPerSecondCubed(left.metresPerSecondSquared / right.seconds);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Frequency"/> that is the result from the division.</returns>
        public static Frequency operator /(Acceleration left, Speed right)
        {
            return Frequency.FromHertz(left.metresPerSecondSquared / right.metresPerSecond);
        }

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Jerk"/> that is the result from the multiplication.</returns>
        public static Jerk operator *(Acceleration left, Frequency right)
        {
            return Jerk.FromMetresPerSecondCubed(left.metresPerSecondSquared * right.hertz);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Speed"/> that is the result from the division.</returns>
        public static Speed operator /(Acceleration left, Frequency right)
        {
            return Speed.FromMetresPerSecond(left.metresPerSecondSquared / right.hertz);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Wavenumber"/> that is the result from the division.</returns>
        public static Wavenumber operator /(Acceleration left, SpecificEnergy right)
        {
            return Wavenumber.FromReciprocalMetres(left.metresPerSecondSquared / right.joulesPerKilogram);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Time"/> that is the result from the division.</returns>
        public static Time operator /(Acceleration left, Jerk right)
        {
            return Time.FromSeconds(left.metresPerSecondSquared / right.metresPerSecondCubed);
        }

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Power"/> that is the result from the multiplication.</returns>
        public static Power operator *(Acceleration left, Momentum right)
        {
            return Power.FromWatts(left.metresPerSecondSquared * right.newtonSecond);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="SpecificEnergy"/> that is the result from the division.</returns>
        public static SpecificEnergy operator /(Acceleration left, Wavenumber right)
        {
            return SpecificEnergy.FromJoulesPerKilogram(left.metresPerSecondSquared / right.reciprocalMetres);
        }

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Pressure"/> that is the result from the multiplication.</returns>
        public static Pressure operator *(Acceleration left, AreaDensity right)
        {
            return Pressure.FromPascals(left.metresPerSecondSquared * right.kilogramsPerSquareMetre);
        }

        /// <summary>
        /// Divides <paramref name="left"/> by <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="double"/> that is the result from the division.</returns>
        public static double operator /(Acceleration left, Acceleration right)
        {
            return left.metresPerSecondSquared / right.metresPerSecondSquared;
        }

        /// <summary>
        /// Indicates whether two <see cref="Gu.Units.Acceleration"/> instances are equal.
        /// </summary>
        /// <returns>
        /// true if the quantities of <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static bool operator ==(Acceleration left, Acceleration right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Indicates whether two <see cref="Gu.Units.Acceleration"/> instances are not equal.
        /// </summary>
        /// <returns>
        /// true if the quantities of <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static bool operator !=(Acceleration left, Acceleration right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Indicates whether a specified <see cref="Gu.Units.Acceleration"/> is less than another specified <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is less than the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static bool operator <(Acceleration left, Acceleration right)
        {
            return left.metresPerSecondSquared < right.metresPerSecondSquared;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="Gu.Units.Acceleration"/> is greater than another specified <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is greater than the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static bool operator >(Acceleration left, Acceleration right)
        {
            return left.metresPerSecondSquared > right.metresPerSecondSquared;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="Gu.Units.Acceleration"/> is less than or equal to another specified <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is less than or equal to the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static bool operator <=(Acceleration left, Acceleration right)
        {
            return left.metresPerSecondSquared <= right.metresPerSecondSquared;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="Gu.Units.Acceleration"/> is greater than or equal to another specified <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is greater than or equal to the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static bool operator >=(Acceleration left, Acceleration right)
        {
            return left.metresPerSecondSquared >= right.metresPerSecondSquared;
        }

        /// <summary>
        /// Multiplies an instance of <see cref="Gu.Units.Acceleration"/> with <paramref name="left"/> and returns the result.
        /// </summary>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="left">The left instance of <seealso cref="double"/></param>
        /// <returns>Multiplies <paramref name="left"/> with <see cref="Gu.Units.Acceleration"/> and returns the result.</returns>
        public static Acceleration operator *(double left, Acceleration right)
        {
            return new Acceleration(left * right.metresPerSecondSquared);
        }

        /// <summary>
        /// Multiplies an instance of <see cref="Gu.Units.Acceleration"/> with <paramref name="right"/> and returns the result.
        /// </summary>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="right">The right instance of <seealso cref="double"/></param>
        /// <returns>Multiplies an <see cref="Gu.Units.Acceleration"/> with <paramref name="right"/> and returns the result.</returns>
        public static Acceleration operator *(Acceleration left, double right)
        {
            return new Acceleration(left.metresPerSecondSquared * right);
        }

        /// <summary>
        /// Divides an instance of <see cref="Gu.Units.Acceleration"/> with <paramref name="right"/> and returns the result.
        /// </summary>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="right">The right instance of <seealso cref="double"/></param>
        /// <returns>Divides an instance of <see cref="Gu.Units.Acceleration"/> by <paramref name="right"/> and returns the result.</returns>
        public static Acceleration operator /(Acceleration left, double right)
        {
            return new Acceleration(left.metresPerSecondSquared / right);
        }

        /// <summary>
        /// Adds two specified <see cref="Gu.Units.Acceleration"/> instances.
        /// </summary>
        /// <returns>
        /// An <see cref="Gu.Units.Acceleration"/> whose quantity is the sum of the quantities of <paramref name="left"/> and <paramref name="right"/>.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/>.</param>
        public static Acceleration operator +(Acceleration left, Acceleration right)
        {
            return new Acceleration(left.metresPerSecondSquared + right.metresPerSecondSquared);
        }

        /// <summary>
        /// Subtracts an Acceleration from another Acceleration and returns the difference.
        /// </summary>
        /// <returns>
        /// An <see cref="Gu.Units.Acceleration"/> that is the difference
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.Acceleration"/> (the minuend).</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.Acceleration"/> (the subtrahend).</param>
        public static Acceleration operator -(Acceleration left, Acceleration right)
        {
            return new Acceleration(left.metresPerSecondSquared - right.metresPerSecondSquared);
        }

        /// <summary>
        /// Returns an <see cref="Gu.Units.Acceleration"/> whose quantity is the negated quantity of the specified instance.
        /// </summary>
        /// <returns>
        /// An <see cref="Gu.Units.Acceleration"/> with the same numeric quantity as this instance, but the opposite sign.
        /// </returns>
        /// <param name="acceleration">An instance of <see cref="Gu.Units.Acceleration"/></param>
        public static Acceleration operator -(Acceleration acceleration)
        {
            return new Acceleration(-1 * acceleration.metresPerSecondSquared);
        }

        /// <summary>
        /// Returns the specified instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <returns>
        /// Returns <paramref name="acceleration"/>.
        /// </returns>
        /// <param name="acceleration">An instance of <see cref="Gu.Units.Acceleration"/></param>
        public static Acceleration operator +(Acceleration acceleration)
        {
            return acceleration;
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <returns>The <see cref="Gu.Units.Acceleration"/> parsed from <paramref name="text"/></returns>
        public static Acceleration Parse(string text)
        {
            return QuantityParser.Parse<AccelerationUnit, Acceleration>(text, From, NumberStyles.Float, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="provider">Specifies the formatProvider to be used.</param>
        /// <returns>The <see cref="Gu.Units.Acceleration"/> parsed from <paramref name="text"/></returns>
        public static Acceleration Parse(string text, IFormatProvider provider)
        {
            return QuantityParser.Parse<AccelerationUnit, Acceleration>(text, From, NumberStyles.Float, provider);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="styles">Specifies the <see cref="NumberStyles"/> to be used.</param>
        /// <returns>The <see cref="Gu.Units.Acceleration"/> parsed from <paramref name="text"/></returns>
        public static Acceleration Parse(string text, NumberStyles styles)
        {
            return QuantityParser.Parse<AccelerationUnit, Acceleration>(text, From, styles, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="styles">Specifies the <see cref="NumberStyles"/> to be used.</param>
        /// <param name="provider">Specifies the formatProvider to be used.</param>
        /// <returns>The <see cref="Gu.Units.Acceleration"/> parsed from <paramref name="text"/></returns>
        public static Acceleration Parse(string text, NumberStyles styles, IFormatProvider provider)
        {
            return QuantityParser.Parse<AccelerationUnit, Acceleration>(text, From, styles, provider);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="result">The parsed <see cref="Acceleration"/></param>
        /// <returns>True if an instance of <see cref="Acceleration"/> could be parsed from <paramref name="text"/></returns>
        public static bool TryParse(string text, out Acceleration result)
        {
            return QuantityParser.TryParse<AccelerationUnit, Acceleration>(text, From, NumberStyles.Float, CultureInfo.CurrentCulture, out result);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="provider">Specifies the formatProvider to be used.</param>
        /// <param name="result">The parsed <see cref="Acceleration"/></param>
        /// <returns>True if an instance of <see cref="Acceleration"/> could be parsed from <paramref name="text"/></returns>
        public static bool TryParse(string text, IFormatProvider provider, out Acceleration result)
        {
            return QuantityParser.TryParse<AccelerationUnit, Acceleration>(text, From, NumberStyles.Float, provider, out result);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="styles">Specifies the <see cref="NumberStyles"/> to be used.</param>
        /// <param name="result">The parsed <see cref="Acceleration"/></param>
        /// <returns>True if an instance of <see cref="Acceleration"/> could be parsed from <paramref name="text"/></returns>
        public static bool TryParse(string text, NumberStyles styles, out Acceleration result)
        {
            return QuantityParser.TryParse<AccelerationUnit, Acceleration>(text, From, styles, CultureInfo.CurrentCulture, out result);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.Acceleration"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.Acceleration"/></param>
        /// <param name="styles">Specifies the <see cref="NumberStyles"/> to be used.</param>
        /// <param name="provider">Specifies the formatProvider to be used.</param>
        /// <param name="result">The parsed <see cref="Acceleration"/></param>
        /// <returns>True if an instance of <see cref="Acceleration"/> could be parsed from <paramref name="text"/></returns>
        public static bool TryParse(string text, NumberStyles styles, IFormatProvider provider, out Acceleration result)
        {
            return QuantityParser.TryParse<AccelerationUnit, Acceleration>(text, From, styles, provider, out result);
        }

        /// <summary>
        /// Reads an instance of <see cref="Gu.Units.Acceleration"/> from the <paramref name="reader"/>
        /// </summary>
        /// <param name="reader">The xml reader positioned at the start of the unit value.</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration ReadFrom(XmlReader reader)
        {
            var v = default(Acceleration);
            v.ReadXml(reader);
            return v;
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="value">The scalar value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration From(double value, AccelerationUnit unit)
        {
            return new Acceleration(unit.ToSiUnit(value));
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="metresPerSecondSquared">The value in <see cref="Gu.Units.AccelerationUnit.MetresPerSecondSquared"/></param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromMetresPerSecondSquared(double metresPerSecondSquared)
        {
            return new Acceleration(metresPerSecondSquared);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="centimetresPerSecondSquared">The value in cm/s².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromCentimetresPerSecondSquared(double centimetresPerSecondSquared)
        {
            return new Acceleration(centimetresPerSecondSquared / 100);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="millimetresPerSecondSquared">The value in mm/s².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromMillimetresPerSecondSquared(double millimetresPerSecondSquared)
        {
            return new Acceleration(millimetresPerSecondSquared / 1000);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="millimetresPerHourSquared">The value in mm/h².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromMillimetresPerHourSquared(double millimetresPerHourSquared)
        {
            return new Acceleration(millimetresPerHourSquared / 12960000000);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="centimetresPerHourSquared">The value in cm/h².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromCentimetresPerHourSquared(double centimetresPerHourSquared)
        {
            return new Acceleration(centimetresPerHourSquared / 1296000000);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="metresPerHourSquared">The value in m/h².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromMetresPerHourSquared(double metresPerHourSquared)
        {
            return new Acceleration(metresPerHourSquared / 12960000);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="metresPerMinuteSquared">The value in m/min².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromMetresPerMinuteSquared(double metresPerMinuteSquared)
        {
            return new Acceleration(metresPerMinuteSquared / 3600);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gu.Units.Acceleration"/>.
        /// </summary>
        /// <param name="millimetresPerMinuteSquared">The value in mm/min².</param>
        /// <returns>An instance of <see cref="Gu.Units.Acceleration"/></returns>
        public static Acceleration FromMillimetresPerMinuteSquared(double millimetresPerMinuteSquared)
        {
            return new Acceleration(millimetresPerMinuteSquared / 3600000);
        }

        /// <summary>
        /// Get the scalar value
        /// </summary>
        /// <param name="unit">The unit to get the value in.</param>
        /// <returns>The scalar value of this in the specified unit</returns>
        public double GetValue(AccelerationUnit unit)
        {
            return unit.FromSiUnit(this.metresPerSecondSquared);
        }

        /// <summary>
        /// Returns a string with the <see cref="SiValue"/> and <see cref="SiUnit"/>
        /// </summary>
        /// <returns>The string representation of the <see cref="Acceleration"/></returns>
        public override string ToString()
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(null, this.SiUnit);
            return this.ToString(quantityFormat, (IFormatProvider?)null);
        }

        /// <summary>
        /// Returns a string with the <see cref="SiValue"/> and <see cref="SiUnit"/>
        /// </summary>
        /// <param name="provider">Specifies the formatProvider to be used.</param>
        /// <returns>The string representation of the <see cref="Acceleration"/></returns>
        public string ToString(IFormatProvider provider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(string.Empty, this.SiUnit);
            return this.ToString(quantityFormat, provider);
        }

        /// <summary>
        /// If an invalid format is provided the string will look like: {value: ??} {unit: ??}
        /// </summary>
        /// <param name="format">Must be a composite format ex: \"F2 m/s²\"</param>
        /// <returns>The string representation of the <see cref="Acceleration"/></returns>
        public string ToString(string format)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(format);
            return this.ToString(quantityFormat, (IFormatProvider?)null);
        }

        /// <summary>
        /// If an invalid format is provided the string will look like: {value: ??} {unit: ??}
        /// </summary>
        /// <param name="format">Must be a composite format ex: \"F2 m/s²\"</param>
        /// <param name="formatProvider">Specifies the formatProvider to be used.</param>
        /// <returns>The string representation of the <see cref="Acceleration"/></returns>
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(format);
            return this.ToString(quantityFormat, formatProvider);
        }

        /// <summary>
        ///  If an invalid format is provided the string will look like: {value: ??} {unit: ??}
        /// </summary>
        /// <param name="valueFormat">For formatting the scalar, format stings valid for <see cref="double"/> are valid
        ///  ex: F2</param>
        /// <param name="symbolFormat">For formatting of the unit ex m/s²</param>
        /// <returns>The string representation of the <see cref="Acceleration"/></returns>
        public string ToString(string valueFormat, string symbolFormat)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(valueFormat, symbolFormat);
            return this.ToString(quantityFormat, (IFormatProvider?)null);
        }

        /// <summary>
        ///  If an invalid format is provided the string will look like: {value: ??} {unit: ??}
        /// </summary>
        /// <param name="valueFormat">For formatting the scalar, format stings valid for <see cref="double"/> are valid
        ///  ex: F2</param>
        /// <param name="symbolFormat">For formatting the unit ex m/s²</param>
        /// <param name="formatProvider">Specifies the <see cref="IFormatProvider"/> to use when creating the string representation.</param>
        /// <returns>The string representation of the <see cref="Acceleration"/></returns>
        public string ToString(string valueFormat, string symbolFormat, IFormatProvider formatProvider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(valueFormat, symbolFormat);
            return this.ToString(quantityFormat, formatProvider);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(AccelerationUnit unit)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(null, unit);
            return this.ToString(quantityFormat, null);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <param name="symbolFormat">Specifies the symbol format to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(AccelerationUnit unit, SymbolFormat symbolFormat)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(null, unit, symbolFormat);
            return this.ToString(quantityFormat, null);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <param name="formatProvider">Specifies the <see cref="IFormatProvider"/> to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(AccelerationUnit unit, IFormatProvider formatProvider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(null, unit);
            return this.ToString(quantityFormat, formatProvider);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <param name="symbolFormat">Specifies the symbol format to use when creating the string representation.</param>
        /// <param name="formatProvider">Specifies the <see cref="IFormatProvider"/> to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(AccelerationUnit unit, SymbolFormat symbolFormat, IFormatProvider formatProvider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(null, unit, symbolFormat);
            return this.ToString(quantityFormat, formatProvider);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="valueFormat">The format to use for the scalar value. Valid formats are formats valid for formatting <see cref="double"/></param>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(string valueFormat, AccelerationUnit unit)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(valueFormat, unit);
            return this.ToString(quantityFormat, null);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="valueFormat">The format to use for the scalar value. Valid formats are formats valid for formatting <see cref="double"/></param>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <param name="symbolFormat">Specifies the symbol format to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(string valueFormat, AccelerationUnit unit, SymbolFormat symbolFormat)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(valueFormat, unit, symbolFormat);
            return this.ToString(quantityFormat, null);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="valueFormat">The format to use for the scalar value. Valid formats are formats valid for formatting <see cref="double"/></param>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <param name="formatProvider">Specifies the <see cref="IFormatProvider"/> to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(string valueFormat, AccelerationUnit unit, IFormatProvider formatProvider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(valueFormat, unit);
            return this.ToString(quantityFormat, formatProvider);
        }

        /// <summary>
        /// Converts the quantity value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="valueFormat">The format to use for the scalar value. Valid formats are formats valid for formatting <see cref="double"/></param>
        /// <param name="unit">The unit to use in the conversion</param>
        /// <param name="symbolFormat">Specifies the symbol format to use when creating the string representation.</param>
        /// <param name="formatProvider">Specifies the <see cref="IFormatProvider"/> to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(string valueFormat, AccelerationUnit unit, SymbolFormat symbolFormat, IFormatProvider formatProvider)
        {
            var quantityFormat = FormatCache<AccelerationUnit>.GetOrCreate(valueFormat, unit, symbolFormat);
            return this.ToString(quantityFormat, formatProvider);
        }

        /// <summary>
        /// Compares this instance to a specified <see cref="Gu.Units.Acceleration"/> object and returns an integer that indicates whether this <paramref name="quantity"/> is smaller than, equal to, or greater than the <see cref="Gu.Units.Acceleration"/> object.
        /// </summary>
        /// <returns>
        /// A signed number indicating the relative quantities of this instance and <paramref name="quantity"/>.
        /// Value
        /// Description
        /// A negative integer
        /// This instance is smaller than <paramref name="quantity"/>.
        /// Zero
        /// This instance is equal to <paramref name="quantity"/>.
        /// A positive integer
        /// This instance is larger than <paramref name="quantity"/>.
        /// </returns>
        /// <param name="quantity">An instance of <see cref="Gu.Units.Acceleration"/> object to compare to this instance.</param>
        public int CompareTo(Acceleration quantity)
        {
            return this.metresPerSecondSquared.CompareTo(quantity.metresPerSecondSquared);
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="Gu.Units.Acceleration"/> object.
        /// </summary>
        /// <returns>
        /// true if <paramref name="other"/> represents the same Acceleration as this instance; otherwise, false.
        /// </returns>
        /// <param name="other">An instance of <see cref="Gu.Units.Acceleration"/> object to compare with this instance.</param>
        public bool Equals(Acceleration other)
        {
            return this.metresPerSecondSquared.Equals(other.metresPerSecondSquared);
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="Gu.Units.Acceleration"/> object within the given tolerance.
        /// </summary>
        /// <returns>
        /// true if <paramref name="other"/> represents the same Acceleration as this instance; otherwise, false.
        /// </returns>
        /// <param name="other">An instance of <see cref="Gu.Units.Acceleration"/> object to compare with this instance.</param>
        /// <param name="tolerance">The maximum difference for being considered equal. Must be greater than zero.</param>
        public bool Equals(Acceleration other, Acceleration tolerance)
        {
            Ensure.GreaterThan(tolerance.metresPerSecondSquared, 0, nameof(tolerance));
            return Math.Abs(this.metresPerSecondSquared - other.metresPerSecondSquared) < tolerance.metresPerSecondSquared;
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="Gu.Units.Acceleration"/> object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// true if <paramref name="obj"/> represents the same <see cref="Gu.Units.Acceleration"/> as this instance; otherwise, false.
        /// </returns>
        public override bool Equals(object? obj)
        {
            return obj is Acceleration other && this.Equals(other);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return this.metresPerSecondSquared.GetHashCode();
        }

        /// <summary>
        /// This method is reserved and should not be used. When implementing the IXmlSerializable interface,
        /// you should return null (Nothing in Visual Basic) from this method, and instead,
        /// if specifying a custom schema is required, apply the <see cref="System.Xml.Serialization.XmlSchemaProviderAttribute"/> to the class.
        /// </summary>
        /// <returns>
        /// An <see cref="System.Xml.Schema.XmlSchema"/> that describes the XML representation of the object that is produced by the
        ///  <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)"/>
        /// method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)"/> method.
        /// </returns>
        public XmlSchema? GetSchema() => null;

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="System.Xml.XmlReader"/> stream from which the object is deserialized. </param>
        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            var attribute = reader.GetAttribute("Value");
            if (attribute is null)
            {
                throw new XmlException($"Could not find attribute named: Value");
            }

            this  = new Acceleration(XmlConvert.ToDouble(attribute), AccelerationUnit.MetresPerSecondSquared);
            reader.ReadStartElement();
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="System.Xml.XmlWriter"/> stream to which the object is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartAttribute("Value");
            writer.WriteValue(this.metresPerSecondSquared);
            writer.WriteEndAttribute();
        }

        internal string ToString(QuantityFormat<AccelerationUnit> format, IFormatProvider? formatProvider)
        {
            using (var builder = StringBuilderPool.Borrow())
            {
                builder.Append(this, format, formatProvider);
                return builder.ToString();
            }
        }
    }
}
