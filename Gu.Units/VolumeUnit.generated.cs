#nullable enable
namespace Gu.Units
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// A type for the unit <see cref="Gu.Units.Volume"/>.
    /// Contains logic for conversion and formatting.
    /// </summary>
    [Serializable]
    [TypeConverter(typeof(VolumeUnitTypeConverter))]
    public struct VolumeUnit : IUnit, IUnit<Volume>, IEquatable<VolumeUnit>
    {
        /// <summary>
        /// The CubicMetres unit
        /// Contains logic for conversion and formatting.
        /// </summary>
        public static readonly VolumeUnit CubicMetres = new VolumeUnit(cubicMetres => cubicMetres, cubicMetres => cubicMetres, "m³");

        /// <summary>
        /// The Litres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit Litres = new VolumeUnit(litres => litres / 1000, cubicMetres => 1000 * cubicMetres, "L");

        /// <summary>
        /// The Millilitres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit Millilitres = new VolumeUnit(millilitres => millilitres / 1000000, cubicMetres => 1000000 * cubicMetres, "ml");

        /// <summary>
        /// The Centilitres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit Centilitres = new VolumeUnit(centilitres => centilitres / 100000, cubicMetres => 100000 * cubicMetres, "cl");

        /// <summary>
        /// The Decilitres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit Decilitres = new VolumeUnit(decilitres => decilitres / 10000, cubicMetres => 10000 * cubicMetres, "dl");

        /// <summary>
        /// The CubicCentimetres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit CubicCentimetres = new VolumeUnit(cubicCentimetres => cubicCentimetres / 1000000, cubicMetres => 1000000 * cubicMetres, "cm³");

        /// <summary>
        /// The CubicMillimetres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit CubicMillimetres = new VolumeUnit(cubicMillimetres => cubicMillimetres / 1000000000, cubicMetres => 1000000000 * cubicMetres, "mm³");

        /// <summary>
        /// The CubicInches unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit CubicInches = new VolumeUnit(cubicInches => 1.6387064E-05 * cubicInches, cubicMetres => cubicMetres / 1.6387064E-05, "in³");

        /// <summary>
        /// The CubicDecimetres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit CubicDecimetres = new VolumeUnit(cubicDecimetres => cubicDecimetres / 1000, cubicMetres => 1000 * cubicMetres, "dm³");

        /// <summary>
        /// The CubicFeet unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly VolumeUnit CubicFeet = new VolumeUnit(cubicFeet => 0.028316846592 * cubicFeet, cubicMetres => cubicMetres / 0.028316846592, "ft³");

#pragma warning disable SA1307 // Accessible fields must begin with upper-case letter
#pragma warning disable SA1304 // Non-private readonly fields must begin with upper-case letter
        /// <summary>
        /// Gets the symbol for the <see cref="Gu.Units.VolumeUnit"/>.
        /// </summary>
        internal readonly string symbol;
#pragma warning restore SA1304 // Non-private readonly fields must begin with upper-case letter
#pragma warning restore SA1307 // Accessible fields must begin with upper-case letter

        private readonly Func<double, double> toCubicMetres;
        private readonly Func<double, double> fromCubicMetres;

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeUnit"/> struct.
        /// </summary>
        /// <param name="toCubicMetres">The conversion to <see cref="CubicMetres"/></param>
        /// <param name="fromCubicMetres">The conversion to <paramref name="symbol"/></param>
        /// <param name="symbol">The symbol for the <see cref="CubicMetres"/></param>
        public VolumeUnit(Func<double, double> toCubicMetres, Func<double, double> fromCubicMetres, string symbol)
        {
            this.toCubicMetres = toCubicMetres;
            this.fromCubicMetres = fromCubicMetres;
            this.symbol = symbol;
        }

        /// <summary>
        /// Gets the symbol for the <see cref="Gu.Units.VolumeUnit"/>.
        /// </summary>
        public string Symbol => this.symbol;

        /// <summary>
        /// Gets the default unit for <see cref="Gu.Units.VolumeUnit"/>
        /// </summary>
        public VolumeUnit SiUnit => CubicMetres;

        /// <inheritdoc />
        IUnit IUnit.SiUnit => CubicMetres;

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Volume"/> that is the result from the multiplication.</returns>
        public static Volume operator *(double left, VolumeUnit right)
        {
            return Volume.From(left, right);
        }

        /// <summary>
        /// Indicates whether two <see cref="Gu.Units.VolumeUnit"/> instances are equal.
        /// </summary>
        /// <returns>
        /// true if the quantities of <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.VolumeUnit"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.VolumeUnit"/>.</param>
        public static bool operator ==(VolumeUnit left, VolumeUnit right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Indicates whether two <see cref="Gu.Units.VolumeUnit"/> instances are not equal.
        /// </summary>
        /// <returns>
        /// true if the quantities of <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.VolumeUnit"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.VolumeUnit"/>.</param>
        public static bool operator !=(VolumeUnit left, VolumeUnit right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Constructs a <see cref="VolumeUnit"/> from a string.
        /// Leading and trailing whitespace characters are allowed.
        /// </summary>
        /// <param name="text">The text representation of this unit.</param>
        /// <returns>An instance of <see cref="VolumeUnit"/></returns>
        public static VolumeUnit Parse(string text)
        {
            return UnitParser<VolumeUnit>.Parse(text);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.VolumeUnit"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.VolumeUnit"/></param>
        /// <param name="result">The parsed <see cref="VolumeUnit"/></param>
        /// <returns>True if an instance of <see cref="VolumeUnit"/> could be parsed from <paramref name="text"/></returns>
        public static bool TryParse(string text, out VolumeUnit result)
        {
            return UnitParser<VolumeUnit>.TryParse(text, out result);
        }

        /// <summary>
        /// Converts <paramref name="value"/> to CubicMetres.
        /// </summary>
        /// <param name="value">The value in the unit of this instance.</param>
        /// <returns>The converted value</returns>
        public double ToSiUnit(double value)
        {
            return this.toCubicMetres(value);
        }

        /// <summary>
        /// Converts a value from cubicMetres.
        /// </summary>
        /// <param name="cubicMetres">The value in CubicMetres</param>
        /// <returns>The converted value</returns>
        public double FromSiUnit(double cubicMetres)
        {
            return this.fromCubicMetres(cubicMetres);
        }

        /// <summary>
        /// Creates a quantity with this unit
        /// </summary>
        /// <param name="value">The scalar value"</param>
        /// <returns>new Volume(<paramref name="value"/>, this)</returns>
        public Volume CreateQuantity(double value)
        {
            return new Volume(value, this);
        }

        /// <summary>
        /// Gets the scalar value of <paramref name="quantity"/> in CubicMetres
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>The SI-unit value.</returns>
        public double GetScalarValue(Volume quantity)
        {
            return this.FromSiUnit(quantity.cubicMetres);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return this.symbol;
        }

        /// <summary>
        /// Converts the unit value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="format">The format to use when converting</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(string format)
        {
            VolumeUnit unit;
            var paddedFormat = UnitFormatCache<VolumeUnit>.GetOrCreate(format, out unit);
            if (unit != this)
            {
                return format;
            }

            using (var builder = StringBuilderPool.Borrow())
            {
                builder.Append(paddedFormat.PrePadding);
                builder.Append(paddedFormat.Format);
                builder.Append(paddedFormat.PostPadding);
                return builder.ToString();
            }
        }

        /// <summary>
        /// Converts the unit value of this instance to its equivalent string representation.
        /// </summary>
        /// <param name="symbolFormat">Specifies the symbol format to use when creating the string representation.</param>
        /// <returns>The string representation of the value of this instance.</returns>
        public string ToString(SymbolFormat symbolFormat)
        {
            var paddedFormat = UnitFormatCache<VolumeUnit>.GetOrCreate(this, symbolFormat);
            using (var builder = StringBuilderPool.Borrow())
            {
                builder.Append(paddedFormat.PrePadding);
                builder.Append(paddedFormat.Format);
                builder.Append(paddedFormat.PostPadding);
                return builder.ToString();
            }
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="Gu.Units.VolumeUnit"/> object.
        /// </summary>
        /// <param name="other">An instance of <see cref="Gu.Units.VolumeUnit"/> object to compare with this instance.</param>
        /// <returns>
        /// true if <paramref name="other"/> represents the same VolumeUnit as this instance; otherwise, false.
        /// </returns>
        public bool Equals(VolumeUnit other)
        {
            return this.symbol == other.symbol;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is VolumeUnit other && this.Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            if (this.symbol is null)
            {
                return 0; // Needed due to default constructor
            }

            return this.symbol.GetHashCode();
        }
    }
}
