﻿namespace Gu.Units
{
    using System;
    using System.Globalization;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    /// A type for the quantity <see cref="T:Gu.Units.Jerk"/>.
    /// </summary>
    [Serializable]
    public partial struct Jerk : IComparable<Jerk>, IEquatable<Jerk>, IFormattable, IXmlSerializable, IQuantity<LengthUnit, I1, TimeUnit, INeg3>, IQuantity<JerkUnit>
    {
        /// <summary>
        /// The quantity in <see cref="T:Gu.Units.MetresPerSecondCubed"/>.
        /// </summary>
        internal readonly double metresPerSecondCubed;

        private Jerk(double metresPerSecondCubed)
        {
            this.metresPerSecondCubed = metresPerSecondCubed;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"><see cref="T:Gu.Units.MetresPerSecondCubed"/>.</param>
        public Jerk(double value, JerkUnit unit)
        {
            this.metresPerSecondCubed = unit.ToSiUnit(value);
        }

        /// <summary>
        /// The quantity in MetresPerSecondCubed
        /// </summary>
        public double SiValue
        {
            get
            {
                return this.metresPerSecondCubed;
            }
        }

        /// <summary>
        /// The quantity in metresPerSecondCubed".
        /// </summary>
        public double MetresPerSecondCubed
        {
            get
            {
                return this.metresPerSecondCubed;
            }
        }

        /// <summary>
        /// The quantity in millimetresPerCubicSecond
        /// </summary>
        public double MillimetresPerCubicSecond
        {
            get
            {
                return JerkUnit.MillimetresPerCubicSecond.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in millimetresPerCubicHour
        /// </summary>
        public double MillimetresPerCubicHour
        {
            get
            {
                return JerkUnit.MillimetresPerCubicHour.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in millimetresPerCubicMinute
        /// </summary>
        public double MillimetresPerCubicMinute
        {
            get
            {
                return JerkUnit.MillimetresPerCubicMinute.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in metresPerCubicHour
        /// </summary>
        public double MetresPerCubicHour
        {
            get
            {
                return JerkUnit.MetresPerCubicHour.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in metresPerCubicMinute
        /// </summary>
        public double MetresPerCubicMinute
        {
            get
            {
                return JerkUnit.MetresPerCubicMinute.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in nanometresPerCubicHour
        /// </summary>
        public double NanometresPerCubicHour
        {
            get
            {
                return JerkUnit.NanometresPerCubicHour.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in nanometresPerCubicMinute
        /// </summary>
        public double NanometresPerCubicMinute
        {
            get
            {
                return JerkUnit.NanometresPerCubicMinute.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in centimetresPerCubicSecond
        /// </summary>
        public double CentimetresPerCubicSecond
        {
            get
            {
                return JerkUnit.CentimetresPerCubicSecond.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in centimetresPerCubicHour
        /// </summary>
        public double CentimetresPerCubicHour
        {
            get
            {
                return JerkUnit.CentimetresPerCubicHour.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// The quantity in centimetresPerCubicMinute
        /// </summary>
        public double CentimetresPerCubicMinute
        {
            get
            {
                return JerkUnit.CentimetresPerCubicMinute.FromSiUnit(this.metresPerSecondCubed);
            }
        }

        /// <summary>
        /// Creates an instance of <see cref="T:Gu.Units.Jerk"/> from its string representation
        /// </summary>
        /// <param name="s">The string representation of the <see cref="T:Gu.Units.Jerk"/></param>
        /// <returns></returns>
        public static Jerk Parse(string s)
        {
            return Parser.Parse<JerkUnit, Jerk>(s, From);
        }

        /// <summary>
        /// Reads an instance of <see cref="T:Gu.Units.Jerk"/> from the <paramref name="reader"/>
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>An instance of  <see cref="T:Gu.Units.Jerk"/></returns>
        public static Jerk ReadFrom(XmlReader reader)
        {
            var v = new Jerk();
            v.ReadXml(reader);
            return v;
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        public static Jerk From(double value, JerkUnit unit)
        {
            return new Jerk(unit.ToSiUnit(value));
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="metresPerSecondCubed">The value in <see cref="T:Gu.Units.MetresPerSecondCubed"/></param>
        public static Jerk FromMetresPerSecondCubed(double metresPerSecondCubed)
        {
            return new Jerk(metresPerSecondCubed);
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="millimetresPerCubicSecond">The value in mm⋅s⁻³</param>
        public static Jerk FromMillimetresPerCubicSecond(double millimetresPerCubicSecond)
        {
            return From(millimetresPerCubicSecond, JerkUnit.MillimetresPerCubicSecond);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="millimetresPerCubicHour">The value in h⁻³⋅mm</param>
        public static Jerk FromMillimetresPerCubicHour(double millimetresPerCubicHour)
        {
            return From(millimetresPerCubicHour, JerkUnit.MillimetresPerCubicHour);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="millimetresPerCubicMinute">The value in min⁻³⋅mm</param>
        public static Jerk FromMillimetresPerCubicMinute(double millimetresPerCubicMinute)
        {
            return From(millimetresPerCubicMinute, JerkUnit.MillimetresPerCubicMinute);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="metresPerCubicHour">The value in h⁻³⋅m</param>
        public static Jerk FromMetresPerCubicHour(double metresPerCubicHour)
        {
            return From(metresPerCubicHour, JerkUnit.MetresPerCubicHour);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="metresPerCubicMinute">The value in min⁻³⋅m</param>
        public static Jerk FromMetresPerCubicMinute(double metresPerCubicMinute)
        {
            return From(metresPerCubicMinute, JerkUnit.MetresPerCubicMinute);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="nanometresPerCubicHour">The value in h⁻³⋅nm</param>
        public static Jerk FromNanometresPerCubicHour(double nanometresPerCubicHour)
        {
            return From(nanometresPerCubicHour, JerkUnit.NanometresPerCubicHour);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="nanometresPerCubicMinute">The value in min⁻³⋅nm</param>
        public static Jerk FromNanometresPerCubicMinute(double nanometresPerCubicMinute)
        {
            return From(nanometresPerCubicMinute, JerkUnit.NanometresPerCubicMinute);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="centimetresPerCubicSecond">The value in cm⋅s⁻³</param>
        public static Jerk FromCentimetresPerCubicSecond(double centimetresPerCubicSecond)
        {
            return From(centimetresPerCubicSecond, JerkUnit.CentimetresPerCubicSecond);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="centimetresPerCubicHour">The value in cm⋅h⁻³</param>
        public static Jerk FromCentimetresPerCubicHour(double centimetresPerCubicHour)
        {
            return From(centimetresPerCubicHour, JerkUnit.CentimetresPerCubicHour);
        }
        /// <summary>
        /// Creates a new instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <param name="centimetresPerCubicMinute">The value in cm⋅min⁻³</param>
        public static Jerk FromCentimetresPerCubicMinute(double centimetresPerCubicMinute)
        {
            return From(centimetresPerCubicMinute, JerkUnit.CentimetresPerCubicMinute);
        }

        public static Frequency operator /(Jerk left, Acceleration right)
        {
            return Frequency.FromHertz(left.metresPerSecondCubed / right.metresPerSecondSquared);
        }

        public static Acceleration operator *(Jerk left, Time right)
        {
            return Acceleration.FromMetresPerSecondSquared(left.metresPerSecondCubed * right.seconds);
        }

        public static double operator /(Jerk left, Jerk right)
        {
            return left.metresPerSecondCubed / right.metresPerSecondCubed;
        }

        /// <summary>
        /// Indicates whether two <see cref="T:Gu.Units.Jerk"/> instances are equal.
        /// </summary>
        /// <returns>
        /// true if the quantitys of <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, false.
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static bool operator ==(Jerk left, Jerk right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Indicates whether two <see cref="T:Gu.Units.Jerk"/> instances are not equal.
        /// </summary>
        /// <returns>
        /// true if the quantitys of <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, false.
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static bool operator !=(Jerk left, Jerk right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Jerk"/> is less than another specified <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is less than the quantity of <paramref name="right"/>; otherwise, false. 
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static bool operator <(Jerk left, Jerk right)
        {
            return left.metresPerSecondCubed < right.metresPerSecondCubed;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Jerk"/> is greater than another specified <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is greater than the quantity of <paramref name="right"/>; otherwise, false. 
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static bool operator >(Jerk left, Jerk right)
        {
            return left.metresPerSecondCubed > right.metresPerSecondCubed;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Jerk"/> is less than or equal to another specified <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is less than or equal to the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static bool operator <=(Jerk left, Jerk right)
        {
            return left.metresPerSecondCubed <= right.metresPerSecondCubed;
        }

        /// <summary>
        /// Indicates whether a specified <see cref="T:Gu.Units.Jerk"/> is greater than or equal to another specified <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <returns>
        /// true if the quantity of <paramref name="left"/> is greater than or equal to the quantity of <paramref name="right"/>; otherwise, false.
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static bool operator >=(Jerk left, Jerk right)
        {
            return left.metresPerSecondCubed >= right.metresPerSecondCubed;
        }

        /// <summary>
        /// Multiplies an instance of <see cref="T:Gu.Units.Jerk"/> with <paramref name="left"/> and returns the result.
        /// </summary>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/></param>
        /// <param name="left">An instance of <seealso cref="T:System.Double"/></param>
        /// <returns>Multiplies an instance of <see cref="T:Gu.Units.Jerk"/> with <paramref name="left"/> and returns the result.</returns>
        public static Jerk operator *(double left, Jerk right)
        {
            return new Jerk(left * right.metresPerSecondCubed);
        }

        /// <summary>
        /// Multiplies an instance of <see cref="T:Gu.Units.Jerk"/> with <paramref name="right"/> and returns the result.
        /// </summary>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/></param>
        /// <param name="right">An instance of <seealso cref="T:System.Double"/></param>
        /// <returns>Multiplies an instance of <see cref="T:Gu.Units.Jerk"/> with <paramref name="right"/> and returns the result.</returns>
        public static Jerk operator *(Jerk left, double right)
        {
            return new Jerk(left.metresPerSecondCubed * right);
        }

        /// <summary>
        /// Divides an instance of <see cref="T:Gu.Units.Jerk"/> with <paramref name="right"/> and returns the result.
        /// </summary>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/></param>
        /// <param name="right">An instance of <seealso cref="T:System.Double"/></param>
        /// <returns>Divides an instance of <see cref="T:Gu.Units.Jerk"/> with <paramref name="right"/> and returns the result.</returns>
        public static Jerk operator /(Jerk left, double right)
        {
            return new Jerk(left.metresPerSecondCubed / right);
        }

        /// <summary>
        /// Adds two specified <see cref="T:Gu.Units.Jerk"/> instances.
        /// </summary>
        /// <returns>
        /// An <see cref="T:Gu.Units.Jerk"/> whose quantity is the sum of the quantitys of <paramref name="left"/> and <paramref name="right"/>.
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/>.</param>
        public static Jerk operator +(Jerk left, Jerk right)
        {
            return new Jerk(left.metresPerSecondCubed + right.metresPerSecondCubed);
        }

        /// <summary>
        /// Subtracts an Jerk from another Jerk and returns the difference.
        /// </summary>
        /// <returns>
        /// An <see cref="T:Gu.Units.Jerk"/> that is the difference
        /// </returns>
        /// <param name="left">An instance of <see cref="T:Gu.Units.Jerk"/> (the minuend).</param>
        /// <param name="right">An instance of <see cref="T:Gu.Units.Jerk"/> (the subtrahend).</param>
        public static Jerk operator -(Jerk left, Jerk right)
        {
            return new Jerk(left.metresPerSecondCubed - right.metresPerSecondCubed);
        }

        /// <summary>
        /// Returns an <see cref="T:Gu.Units.Jerk"/> whose quantity is the negated quantity of the specified instance.
        /// </summary>
        /// <returns>
        /// An <see cref="T:Gu.Units.Jerk"/> with the same numeric quantity as this instance, but the opposite sign.
        /// </returns>
        /// <param name="jerk">An instance of <see cref="T:Gu.Units.Jerk"/></param>
        public static Jerk operator -(Jerk jerk)
        {
            return new Jerk(-1 * jerk.metresPerSecondCubed);
        }

        /// <summary>
        /// Returns the specified instance of <see cref="T:Gu.Units.Jerk"/>.
        /// </summary>
        /// <returns>
        /// Returns <paramref name="jerk"/>.
        /// </returns>
        /// <param name="jerk">An instance of <see cref="T:Gu.Units.Jerk"/></param>
        public static Jerk operator +(Jerk jerk)
        {
            return jerk;
        }

        /// <summary>
        /// Get the scalar value
        /// </summary>
        /// <param name="unit"></param>
        /// <returns>The scalar value of this in the specified unit</returns>
        public double GetValue(JerkUnit unit)
        {
            return unit.FromSiUnit(this.metresPerSecondCubed);
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
            return this.ToString(format, formatProvider, JerkUnit.MetresPerSecondCubed);
        }

        public string ToString(JerkUnit unit)
        {
            return this.ToString((string)null, (IFormatProvider)NumberFormatInfo.CurrentInfo, unit);
        }

        public string ToString(string format, JerkUnit unit)
        {
            return this.ToString(format, (IFormatProvider)NumberFormatInfo.CurrentInfo, unit);
        }

        public string ToString(string format, IFormatProvider formatProvider, JerkUnit unit)
        {
            var quantity = unit.FromSiUnit(this.metresPerSecondCubed);
            return string.Format("{0}{1}", quantity.ToString(format, formatProvider), unit.Symbol);
        }

        /// <summary>
        /// Compares this instance to a specified <see cref="T:MathNet.Spatial.Units.Jerk"/> object and returns an integer that indicates whether this <see cref="quantity"/> is smaller than, equal to, or greater than the <see cref="T:MathNet.Spatial.Units.Jerk"/> object.
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
        /// <param name="quantity">An instance of <see cref="T:MathNet.Spatial.Units.Jerk"/> object to compare to this instance.</param>
        public int CompareTo(Jerk quantity)
        {
            return this.metresPerSecondCubed.CompareTo(quantity.metresPerSecondCubed);
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="T:Gu.Units.Jerk"/> object.
        /// </summary>
        /// <returns>
        /// true if <paramref name="other"/> represents the same Jerk as this instance; otherwise, false.
        /// </returns>
        /// <param name="other">An instance of <see cref="T:Gu.Units.Jerk"/> object to compare with this instance.</param>
        public bool Equals(Jerk other)
        {
            return this.metresPerSecondCubed.Equals(other.metresPerSecondCubed);
        }

        /// <summary>
        /// Returns a quantity indicating whether this instance is equal to a specified <see cref="T:Gu.Units.Jerk"/> object within the given tolerance.
        /// </summary>
        /// <returns>
        /// true if <paramref name="other"/> represents the same Jerk as this instance; otherwise, false.
        /// </returns>
        /// <param name="other">An instance of <see cref="T:Gu.Units.Jerk"/> object to compare with this instance.</param>
        /// <param name="tolerance">The maximum difference for being considered equal</param>
        public bool Equals(Jerk other, double tolerance)
        {
            return Math.Abs(this.metresPerSecondCubed - other.metresPerSecondCubed) < tolerance;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Jerk && this.Equals((Jerk)obj);
        }

        public override int GetHashCode()
        {
            return this.metresPerSecondCubed.GetHashCode();
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
            XmlExt.SetReadonlyField(ref this, "metresPerSecondCubed", reader, "Value");
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> stream to which the object is serialized. </param>
        public void WriteXml(XmlWriter writer)
        {
            XmlExt.WriteAttribute(writer, "Value", this.metresPerSecondCubed);
        }
    }
}