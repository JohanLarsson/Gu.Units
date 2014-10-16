﻿namespace Gu.Units
{
    using System;
    using System.Globalization;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    /// A type for the quantity <see cref="T:Gu.Units.Density"/>.
    /// </summary>
    [Serializable]
    public partial struct Density : IComparable<Density>, IEquatable<Density>, IFormattable, IXmlSerializable, IQuantity<MassUnit, I1, LengthUnit, INeg3>
    {
        /// <summary>
        /// The quantity in <see cref="T:Gu.Units.KilogramsPerCubicMetre"/>.
        /// </summary>
        public readonly double KilogramsPerCubicMetre;

        private Density(double kilogramsPerCubicMetre)
        {
            KilogramsPerCubicMetre = kilogramsPerCubicMetre;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"><see cref="T:Gu.Units.KilogramsPerCubicMetre"/>.</param>
        public Density(double value, DensityUnit unit)
        {
            KilogramsPerCubicMetre = unit.ToSiUnit(value);
        }

        /// <summary>
        /// The quantity in KilogramsPerCubicMetre
        /// </summary>
        public double SiValue
        {
            get
            {
                return KilogramsPerCubicMetre;
            }
        }

        /// <summary>
        /// The quantity in gramsPerCubicMillimetre
        /// </summary>
        public double GramsPerCubicMillimetre
        {
            get
            {
                return DensityUnit.GramsPerCubicMillimetre.FromSiUnit(KilogramsPerCubicMetre);
            }
        }

        /// <summary>
        /// The quantity in gramsPerCubicCentimetre
        /// </summary>
        public double GramsPerCubicCentimetre
        {
            get
            {
                return DensityUnit.GramsPerCubicCentimetre.FromSiUnit(KilogramsPerCubicMetre);
            }
        }

        /// <summary>
        /// Creates an instance of <see cref="T:Gu.Units.Density"/> from its string representation
        /// </summary>
        /// <param name="s">The string representation of the <see cref="T:Gu.Units.Density"/></param>
        /// <returns></returns>
        public static Density Parse(string s)
        {
            return Parser.Parse<DensityUnit, Density>(s, From);
        }

        /// <summary>
        /// Reads an instance of <see cref="T:Gu.Units.Density"/> from the <paramref name="reader"/>
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>An instance of  <see cref="T:Gu.Units.Density"/></returns>
        public static Density ReadFrom(XmlReader reader)
        {
            var v = new Density();
            v.ReadXml(reader);
            return v;
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        public static Density From(double value, DensityUnit unit)
        {
            return new Density(unit.ToSiUnit(value));
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <param name="kilogramsPerCubicMetre">The value in <see cref="T:Gu.Units.KilogramsPerCubicMetre"/></param>
        public static Density FromKilogramsPerCubicMetre(double kilogramsPerCubicMetre)
        {
            return new Density(kilogramsPerCubicMetre);
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <param name="gramsPerCubicMillimetre">The value in g / mm³</param>
        public static Density FromGramsPerCubicMillimetre(double gramsPerCubicMillimetre)
        {
            return From(gramsPerCubicMillimetre, DensityUnit.GramsPerCubicMillimetre);
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <param name="gramsPerCubicCentimetre">The value in g / cm³</param>
        public static Density FromGramsPerCubicCentimetre(double gramsPerCubicCentimetre)
        {
            return From(gramsPerCubicCentimetre, DensityUnit.GramsPerCubicCentimetre);
        }

        /// <summary>
        /// Indicates whether two <see cref="T:Gu.Units.Density"/> instances are equal.
        /// </summary>
        /// <returns>
        /// true if the quantitys of <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, false.
        /// </returns>
        /// <param name="left">A <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">A <see cref="T:Gu.Units.Density"/>.</param>
        public static bool operator ==(Density left, Density right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Indicates whether two <see cref="T:Gu.Units.Density"/> instances are not equal.
        /// </summary>
        /// <returns>
        /// true if the quantitys of <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, false.
        /// </returns>
        /// <param name="left">A <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">A <see cref="T:Gu.Units.Density"/>.</param>
        public static bool operator !=(Density left, Density right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Density"/> is less than another specified <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is less than the quantity of <paramref name="right"/>; otherwise, false. 
        /// </returns>
        /// <param name="left">An <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">An <see cref="T:Gu.Units.Density"/>.</param>
        public static bool operator <(Density left, Density right)
        {
            return left.KilogramsPerCubicMetre < right.KilogramsPerCubicMetre;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Density"/> is greater than another specified <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is greater than the quantity of <paramref name="right"/>; otherwise, false. 
        /// </returns>
        /// <param name="left">An <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">An <see cref="T:Gu.Units.Density"/>.</param>
        public static bool operator >(Density left, Density right)
        {
            return left.KilogramsPerCubicMetre > right.KilogramsPerCubicMetre;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Density"/> is less than or equal to another specified <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is less than or equal to the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">An <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">An <see cref="T:Gu.Units.Density"/>.</param>
        public static bool operator <=(Density left, Density right)
        {
            return left.KilogramsPerCubicMetre <= right.KilogramsPerCubicMetre;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Density"/> is greater than or equal to another specified <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is greater than or equal to the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">An <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">An <see cref="T:Gu.Units.Density"/>.</param>
        public static bool operator >=(Density left, Density right)
        {
            return left.KilogramsPerCubicMetre >= right.KilogramsPerCubicMetre;
        }

        /// <summary>
        /// Multiplies an instance of <see cref="T:Gu.Units.Density"/> with <paramref name="left"/> and returns the result.
        /// </summary>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Density"/></param>
        /// <param name="left">An instance of <seealso cref="T:System.Double"/></param>
        /// <returns>Multiplies an instance of <see cref="T:Gu.Units.Density"/> with <paramref name="left"/> and returns the result.</returns>
        public static Density operator *(double left, Density right)
        {
            return new Density(left * right.KilogramsPerCubicMetre);
        }

        /// <summary>
        /// Multiplies an instance of <see cref="T:Gu.Units.Density"/> with <paramref name="right"/> and returns the result.
        /// </summary>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Density"/></param>
        /// <param name="right">An instance of <seealso cref="T:System.Double"/></param>
        /// <returns>Multiplies an instance of <see cref="T:Gu.Units.Density"/> with <paramref name="right"/> and returns the result.</returns>
        public static Density operator *(Density left, double right)
        {
            return new Density(left.KilogramsPerCubicMetre * right);
        }

        /// <summary>
        /// Divides an instance of <see cref="T:Gu.Units.Density"/> with <paramref name="right"/> and returns the result.
        /// </summary>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Density"/></param>
        /// <param name="right">An instance of <seealso cref="T:System.Double"/></param>
        /// <returns>Divides an instance of <see cref="T:Gu.Units.Density"/> with <paramref name="right"/> and returns the result.</returns>
        public static Density operator /(Density left, double right)
        {
            return new Density(left.KilogramsPerCubicMetre / right);
        }

        /// <summary>
        /// Adds two specified <see cref="T:Gu.Units.Density"/> instances.
        /// </summary>
        /// <returns>
        /// An <see cref="T:Gu.Units.Density"/> whose quantity is the sum of the quantitys of <paramref name="left"/> and <paramref name="right"/>.
        /// </returns>
        /// <param name="left">A <see cref="T:Gu.Units.Density"/>.</param>
        /// <param name="right">A TimeSpan.</param>
        public static Density operator +(Density left, Density right)
        {
            return new Density(left.KilogramsPerCubicMetre + right.KilogramsPerCubicMetre);
        }

        /// <summary>
        /// Subtracts an Density from another Density and returns the difference.
        /// </summary>
        /// <returns>
        /// An <see cref="T:Gu.Units.Density"/> that is the difference
        /// </returns>
        /// <param name="left">A <see cref="T:Gu.Units.Density"/> (the minuend).</param>
        /// <param name="right">A <see cref="T:Gu.Units.Density"/> (the subtrahend).</param>
        public static Density operator -(Density left, Density right)
        {
            return new Density(left.KilogramsPerCubicMetre - right.KilogramsPerCubicMetre);
        }

        /// <summary>
        /// Returns an <see cref="T:Gu.Units.Density"/> whose quantity is the negated quantity of the specified instance.
        /// </summary>
        /// <returns>
        /// An <see cref="T:Gu.Units.Density"/> with the same numeric quantity as this instance, but the opposite sign.
        /// </returns>
        /// <param name="Density">A <see cref="T:Gu.Units.Density"/></param>
        public static Density operator -(Density Density)
        {
            return new Density(-1 * Density.KilogramsPerCubicMetre);
        }

        /// <summary>
        /// Returns the specified instance of <see cref="T:Gu.Units.Density"/>.
        /// </summary>
        /// <returns>
        /// Returns <paramref name="Density"/>.
        /// </returns>
        /// <param name="Density">A <see cref="T:Gu.Units.Density"/></param>
        public static Density operator +(Density Density)
        {
            return Density;
        }

        public override string ToString()
        {
            return this.ToString((string)null, (IFormatProvider)NumberFormatInfo.CurrentInfo);
        }

        public string ToString(string format)
        {
            return this.ToString(format, (IFormatProvider)NumberFormatInfo.CurrentInfo);
        }

        public string ToString(IFormatProvider provider)
        {
            return this.ToString((string)null, (IFormatProvider)NumberFormatInfo.GetInstance(provider));
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString(format, formatProvider, DensityUnit.KilogramsPerCubicMetre);
        }

        public string ToString(string format, IFormatProvider formatProvider, DensityUnit unit)
        {
            var quantity = unit.FromSiUnit(this.KilogramsPerCubicMetre);
            return string.Format("{0}{1}", quantity.ToString(format, formatProvider), unit.Symbol);
        }

        /// <summary>
        /// Compares this instance to a specified <see cref="T:MathNet.Spatial.Units.Density"/> object and returns an integer that indicates whether this <see cref="instance"/> is shorter than, equal to, or longer than the <see cref="T:MathNet.Spatial.Units.Density"/> object.
        /// </summary>
        /// <returns>
        /// A signed number indicating the relative quantitys of this instance and <paramref name="quantity"/>.
        /// 
        ///                     Value
        /// 
        ///                     Description
        /// 
        ///                     A negative integer
        /// 
        ///                     This instance is smaller than <paramref name="quantity"/>.
        /// 
        ///                     Zero
        /// 
        ///                     This instance is equal to <paramref name="quantity"/>.
        /// 
        ///                     A positive integer
        /// 
        ///                     This instance is larger than <paramref name="quantity"/>.
        /// 
        /// </returns>
        /// <param name="quantity">A <see cref="T:MathNet.Spatial.Units.Density"/> object to compare to this instance.</param>
        public int CompareTo(Density quantity)
        {
            return this.KilogramsPerCubicMetre.CompareTo(quantity.KilogramsPerCubicMetre);
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="T:Gu.Units.Density"/> object.
        /// </summary>
        /// <returns>
        /// true if <paramref name="other"/> represents the same Density as this instance; otherwise, false.
        /// </returns>
        /// <param name="other">An <see cref="T:Gu.Units.Density"/> object to compare with this instance.</param>
        public bool Equals(Density other)
        {
            return this.KilogramsPerCubicMetre.Equals(other.KilogramsPerCubicMetre);
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="T:Gu.Units.Density"/> object within the given tolerance.
        /// </summary>
        /// <returns>
        /// true if <paramref name="other"/> represents the same Density as this instance; otherwise, false.
        /// </returns>
        /// <param name="other">An <see cref="T:Gu.Units.Density"/> object to compare with this instance.</param>
        /// <param name="tolerance">The maximum difference for being considered equal</param>
        public bool Equals(Density other, double tolerance)
        {
            return Math.Abs(this.KilogramsPerCubicMetre - other.KilogramsPerCubicMetre) < tolerance;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Density && this.Equals((Density)obj);
        }

        public override int GetHashCode()
        {
            return this.KilogramsPerCubicMetre.GetHashCode();
        }

        /// <summary>
        /// This method is reserved and should not be used. When implementing the IXmlSerializable interface, 
        /// you should return null (Nothing in Visual Basic) from this method, and instead, 
        /// if specifying a custom schema is required, apply the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute"/> to the class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Xml.Schema.XmlSchema"/> that describes the XML representation of the object that is produced by the
        ///  <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)"/> 
        /// method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)"/> method.
        /// </returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> stream from which the object is deserialized. </param>
        public void ReadXml(XmlReader reader)
        {
            // Hacking set readonly fields here, can't think of a cleaner workaround
            XmlExt.SetReadonlyField(ref this, x => x.KilogramsPerCubicMetre, reader, "Value");
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> stream to which the object is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            XmlExt.WriteAttribute(writer, "Value", this.KilogramsPerCubicMetre);
        }
    }
}
