#nullable enable
namespace Gu.Units
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// A type for the unit <see cref="Gu.Units.Area"/>.
    /// Contains logic for conversion and formatting.
    /// </summary>
    [Serializable]
    [TypeConverter(typeof(AreaUnitTypeConverter))]
    public struct AreaUnit : IUnit, IUnit<Area>, IEquatable<AreaUnit>
    {
        /// <summary>
        /// The SquareMetres unit
        /// Contains logic for conversion and formatting.
        /// </summary>
        public static readonly AreaUnit SquareMetres = new AreaUnit(squareMetres => squareMetres, squareMetres => squareMetres, "m²");

        /// <summary>
        /// The Hectares unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit Hectares = new AreaUnit(hectares => 10000 * hectares, squareMetres => squareMetres / 10000, "ha");

        /// <summary>
        /// The SquareMillimetres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareMillimetres = new AreaUnit(squareMillimetres => squareMillimetres / 1000000, squareMetres => 1000000 * squareMetres, "mm²");

        /// <summary>
        /// The SquareCentimetres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareCentimetres = new AreaUnit(squareCentimetres => squareCentimetres / 10000, squareMetres => 10000 * squareMetres, "cm²");

        /// <summary>
        /// The SquareDecimetres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareDecimetres = new AreaUnit(squareDecimetres => squareDecimetres / 100, squareMetres => 100 * squareMetres, "dm²");

        /// <summary>
        /// The SquareKilometres unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareKilometres = new AreaUnit(squareKilometres => 1000000 * squareKilometres, squareMetres => squareMetres / 1000000, "km²");

        /// <summary>
        /// The SquareMile unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareMile = new AreaUnit(squareMile => 2589988.110336 * squareMile, squareMetres => squareMetres / 2589988.110336, "mi²");

        /// <summary>
        /// The SquareYards unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareYards = new AreaUnit(squareYards => 0.83612736 * squareYards, squareMetres => squareMetres / 0.83612736, "yd²");

        /// <summary>
        /// The SquareInches unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareInches = new AreaUnit(squareInches => 0.00064516 * squareInches, squareMetres => squareMetres / 0.00064516, "in²");

        /// <summary>
        /// The SquareFeet unit
        /// Contains conversion logic to from and formatting.
        /// </summary>
        public static readonly AreaUnit SquareFeet = new AreaUnit(squareFeet => 0.09290304 * squareFeet, squareMetres => squareMetres / 0.09290304, "ft²");

#pragma warning disable SA1307 // Accessible fields must begin with upper-case letter
#pragma warning disable SA1304 // Non-private readonly fields must begin with upper-case letter
        /// <summary>
        /// Gets the symbol for the <see cref="Gu.Units.AreaUnit"/>.
        /// </summary>
        internal readonly string symbol;
#pragma warning restore SA1304 // Non-private readonly fields must begin with upper-case letter
#pragma warning restore SA1307 // Accessible fields must begin with upper-case letter

        private readonly Func<double, double> toSquareMetres;
        private readonly Func<double, double> fromSquareMetres;

        /// <summary>
        /// Initializes a new instance of the <see cref="AreaUnit"/> struct.
        /// </summary>
        /// <param name="toSquareMetres">The conversion to <see cref="SquareMetres"/></param>
        /// <param name="fromSquareMetres">The conversion to <paramref name="symbol"/></param>
        /// <param name="symbol">The symbol for the <see cref="SquareMetres"/></param>
        public AreaUnit(Func<double, double> toSquareMetres, Func<double, double> fromSquareMetres, string symbol)
        {
            this.toSquareMetres = toSquareMetres;
            this.fromSquareMetres = fromSquareMetres;
            this.symbol = symbol;
        }

        /// <summary>
        /// Gets the symbol for the <see cref="Gu.Units.AreaUnit"/>.
        /// </summary>
        public string Symbol => this.symbol;

        /// <summary>
        /// Gets the default unit for <see cref="Gu.Units.AreaUnit"/>
        /// </summary>
        public AreaUnit SiUnit => SquareMetres;

        /// <inheritdoc />
        IUnit IUnit.SiUnit => SquareMetres;

        /// <summary>
        /// Multiplies <paramref name="left"/> with <paramref name="right"/>
        /// </summary>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The <see cref="Area"/> that is the result from the multiplication.</returns>
        public static Area operator *(double left, AreaUnit right)
        {
            return Area.From(left, right);
        }

        /// <summary>
        /// Indicates whether two <see cref="Gu.Units.AreaUnit"/> instances are equal.
        /// </summary>
        /// <returns>
        /// true if the quantities of <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.AreaUnit"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.AreaUnit"/>.</param>
        public static bool operator ==(AreaUnit left, AreaUnit right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Indicates whether two <see cref="Gu.Units.AreaUnit"/> instances are not equal.
        /// </summary>
        /// <returns>
        /// true if the quantities of <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, false.
        /// </returns>
        /// <param name="left">The left instance of <see cref="Gu.Units.AreaUnit"/>.</param>
        /// <param name="right">The right instance of <see cref="Gu.Units.AreaUnit"/>.</param>
        public static bool operator !=(AreaUnit left, AreaUnit right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Constructs a <see cref="AreaUnit"/> from a string.
        /// Leading and trailing whitespace characters are allowed.
        /// </summary>
        /// <param name="text">The text representation of this unit.</param>
        /// <returns>An instance of <see cref="AreaUnit"/></returns>
        public static AreaUnit Parse(string text)
        {
            return UnitParser<AreaUnit>.Parse(text);
        }

        /// <summary>
        /// Creates an instance of <see cref="Gu.Units.AreaUnit"/> from its string representation
        /// </summary>
        /// <param name="text">The string representation of the <see cref="Gu.Units.AreaUnit"/></param>
        /// <param name="result">The parsed <see cref="AreaUnit"/></param>
        /// <returns>True if an instance of <see cref="AreaUnit"/> could be parsed from <paramref name="text"/></returns>
        public static bool TryParse(string text, out AreaUnit result)
        {
            return UnitParser<AreaUnit>.TryParse(text, out result);
        }

        /// <summary>
        /// Converts <paramref name="value"/> to SquareMetres.
        /// </summary>
        /// <param name="value">The value in the unit of this instance.</param>
        /// <returns>The converted value</returns>
        public double ToSiUnit(double value)
        {
            return this.toSquareMetres(value);
        }

        /// <summary>
        /// Converts a value from squareMetres.
        /// </summary>
        /// <param name="squareMetres">The value in SquareMetres</param>
        /// <returns>The converted value</returns>
        public double FromSiUnit(double squareMetres)
        {
            return this.fromSquareMetres(squareMetres);
        }

        /// <summary>
        /// Creates a quantity with this unit
        /// </summary>
        /// <param name="value">The scalar value"</param>
        /// <returns>new Area(<paramref name="value"/>, this)</returns>
        public Area CreateQuantity(double value)
        {
            return new Area(value, this);
        }

        /// <summary>
        /// Gets the scalar value of <paramref name="quantity"/> in SquareMetres
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <returns>The SI-unit value.</returns>
        public double GetScalarValue(Area quantity)
        {
            return this.FromSiUnit(quantity.squareMetres);
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
            AreaUnit unit;
            var paddedFormat = UnitFormatCache<AreaUnit>.GetOrCreate(format, out unit);
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
            var paddedFormat = UnitFormatCache<AreaUnit>.GetOrCreate(this, symbolFormat);
            using (var builder = StringBuilderPool.Borrow())
            {
                builder.Append(paddedFormat.PrePadding);
                builder.Append(paddedFormat.Format);
                builder.Append(paddedFormat.PostPadding);
                return builder.ToString();
            }
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="Gu.Units.AreaUnit"/> object.
        /// </summary>
        /// <param name="other">An instance of <see cref="Gu.Units.AreaUnit"/> object to compare with this instance.</param>
        /// <returns>
        /// true if <paramref name="other"/> represents the same AreaUnit as this instance; otherwise, false.
        /// </returns>
        public bool Equals(AreaUnit other)
        {
            return this.symbol == other.symbol;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is AreaUnit other && this.Equals(other);
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
