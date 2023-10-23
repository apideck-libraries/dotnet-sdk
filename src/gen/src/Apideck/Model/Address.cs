/*
 * Apideck
 *
 * The Apideck OpenAPI Spec: SDK Optimized
 *
 * The version of the OpenAPI document: 9.9.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Apideck.Client.OpenAPIDateConverter;

namespace Apideck.Model
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// The type of address.
        /// </summary>
        /// <value>The type of address.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Primary for value: primary
            /// </summary>
            [EnumMember(Value = "primary")]
            Primary = 1,

            /// <summary>
            /// Enum Secondary for value: secondary
            /// </summary>
            [EnumMember(Value = "secondary")]
            Secondary = 2,

            /// <summary>
            /// Enum Home for value: home
            /// </summary>
            [EnumMember(Value = "home")]
            Home = 3,

            /// <summary>
            /// Enum Office for value: office
            /// </summary>
            [EnumMember(Value = "office")]
            Office = 4,

            /// <summary>
            /// Enum Shipping for value: shipping
            /// </summary>
            [EnumMember(Value = "shipping")]
            Shipping = 5,

            /// <summary>
            /// Enum Billing for value: billing
            /// </summary>
            [EnumMember(Value = "billing")]
            Billing = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

        }


        /// <summary>
        /// The type of address.
        /// </summary>
        /// <value>The type of address.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the address..</param>
        /// <param name="type">The type of address..</param>
        /// <param name="_string">The address string. Some APIs don&#39;t provide structured address data..</param>
        /// <param name="name">The name of the address..</param>
        /// <param name="line1">Line 1 of the address e.g. number, street, suite, apt #, etc..</param>
        /// <param name="line2">Line 2 of the address.</param>
        /// <param name="line3">Line 3 of the address.</param>
        /// <param name="line4">Line 4 of the address.</param>
        /// <param name="streetNumber">Street number.</param>
        /// <param name="city">Name of city..</param>
        /// <param name="state">Name of state.</param>
        /// <param name="postalCode">Zip code or equivalent..</param>
        /// <param name="country">country code according to ISO 3166-1 alpha-2..</param>
        /// <param name="latitude">Latitude of the address.</param>
        /// <param name="longitude">Longitude of the address.</param>
        /// <param name="county">Address field that holds a sublocality, such as a county.</param>
        /// <param name="contactName">Name of the contact person at the address.</param>
        /// <param name="salutation">Salutation of the contact person at the address.</param>
        /// <param name="phoneNumber">Phone number of the address.</param>
        /// <param name="fax">Fax number of the address.</param>
        /// <param name="email">Email address of the address.</param>
        /// <param name="website">Website of the address.</param>
        /// <param name="notes">Additional notes.</param>
        /// <param name="rowVersion">A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object..</param>
        public Address(string id = default(string), TypeEnum? type = default(TypeEnum?), string _string = default(string), string name = default(string), string line1 = default(string), string line2 = default(string), string line3 = default(string), string line4 = default(string), string streetNumber = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string country = default(string), string latitude = default(string), string longitude = default(string), string county = default(string), string contactName = default(string), string salutation = default(string), string phoneNumber = default(string), string fax = default(string), string email = default(string), string website = default(string), string notes = default(string), string rowVersion = default(string))
        {
            this.Id = id;
            this.Type = type;
            this.String = _string;
            this.Name = name;
            this.Line1 = line1;
            this.Line2 = line2;
            this.Line3 = line3;
            this.Line4 = line4;
            this.StreetNumber = streetNumber;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.County = county;
            this.ContactName = contactName;
            this.Salutation = salutation;
            this.PhoneNumber = phoneNumber;
            this.Fax = fax;
            this.Email = email;
            this.Website = website;
            this.Notes = notes;
            this.RowVersion = rowVersion;
        }

        /// <summary>
        /// Unique identifier for the address.
        /// </summary>
        /// <value>Unique identifier for the address.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The address string. Some APIs don&#39;t provide structured address data.
        /// </summary>
        /// <value>The address string. Some APIs don&#39;t provide structured address data.</value>
        [DataMember(Name = "string", EmitDefaultValue = true)]
        public string String { get; set; }

        /// <summary>
        /// The name of the address.
        /// </summary>
        /// <value>The name of the address.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Line 1 of the address e.g. number, street, suite, apt #, etc.
        /// </summary>
        /// <value>Line 1 of the address e.g. number, street, suite, apt #, etc.</value>
        [DataMember(Name = "line1", EmitDefaultValue = true)]
        public string Line1 { get; set; }

        /// <summary>
        /// Line 2 of the address
        /// </summary>
        /// <value>Line 2 of the address</value>
        [DataMember(Name = "line2", EmitDefaultValue = true)]
        public string Line2 { get; set; }

        /// <summary>
        /// Line 3 of the address
        /// </summary>
        /// <value>Line 3 of the address</value>
        [DataMember(Name = "line3", EmitDefaultValue = true)]
        public string Line3 { get; set; }

        /// <summary>
        /// Line 4 of the address
        /// </summary>
        /// <value>Line 4 of the address</value>
        [DataMember(Name = "line4", EmitDefaultValue = true)]
        public string Line4 { get; set; }

        /// <summary>
        /// Street number
        /// </summary>
        /// <value>Street number</value>
        [DataMember(Name = "street_number", EmitDefaultValue = true)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Name of city.
        /// </summary>
        /// <value>Name of city.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Name of state
        /// </summary>
        /// <value>Name of state</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip code or equivalent.
        /// </summary>
        /// <value>Zip code or equivalent.</value>
        [DataMember(Name = "postal_code", EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// country code according to ISO 3166-1 alpha-2.
        /// </summary>
        /// <value>country code according to ISO 3166-1 alpha-2.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Latitude of the address
        /// </summary>
        /// <value>Latitude of the address</value>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude of the address
        /// </summary>
        /// <value>Longitude of the address</value>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public string Longitude { get; set; }

        /// <summary>
        /// Address field that holds a sublocality, such as a county
        /// </summary>
        /// <value>Address field that holds a sublocality, such as a county</value>
        [DataMember(Name = "county", EmitDefaultValue = true)]
        public string County { get; set; }

        /// <summary>
        /// Name of the contact person at the address
        /// </summary>
        /// <value>Name of the contact person at the address</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = true)]
        public string ContactName { get; set; }

        /// <summary>
        /// Salutation of the contact person at the address
        /// </summary>
        /// <value>Salutation of the contact person at the address</value>
        [DataMember(Name = "salutation", EmitDefaultValue = true)]
        public string Salutation { get; set; }

        /// <summary>
        /// Phone number of the address
        /// </summary>
        /// <value>Phone number of the address</value>
        [DataMember(Name = "phone_number", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Fax number of the address
        /// </summary>
        /// <value>Fax number of the address</value>
        [DataMember(Name = "fax", EmitDefaultValue = true)]
        public string Fax { get; set; }

        /// <summary>
        /// Email address of the address
        /// </summary>
        /// <value>Email address of the address</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Website of the address
        /// </summary>
        /// <value>Website of the address</value>
        [DataMember(Name = "website", EmitDefaultValue = true)]
        public string Website { get; set; }

        /// <summary>
        /// Additional notes
        /// </summary>
        /// <value>Additional notes</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.
        /// </summary>
        /// <value>A binary value used to detect updates to a object and prevent data conflicts. It is incremented each time an update is made to the object.</value>
        [DataMember(Name = "row_version", EmitDefaultValue = true)]
        public string RowVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Line3: ").Append(Line3).Append("\n");
            sb.Append("  Line4: ").Append(Line4).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.String == input.String ||
                    (this.String != null &&
                    this.String.Equals(input.String))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.Line3 == input.Line3 ||
                    (this.Line3 != null &&
                    this.Line3.Equals(input.Line3))
                ) && 
                (
                    this.Line4 == input.Line4 ||
                    (this.Line4 != null &&
                    this.Line4.Equals(input.Line4))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.RowVersion == input.RowVersion ||
                    (this.RowVersion != null &&
                    this.RowVersion.Equals(input.RowVersion))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.String != null)
                {
                    hashCode = (hashCode * 59) + this.String.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Line1 != null)
                {
                    hashCode = (hashCode * 59) + this.Line1.GetHashCode();
                }
                if (this.Line2 != null)
                {
                    hashCode = (hashCode * 59) + this.Line2.GetHashCode();
                }
                if (this.Line3 != null)
                {
                    hashCode = (hashCode * 59) + this.Line3.GetHashCode();
                }
                if (this.Line4 != null)
                {
                    hashCode = (hashCode * 59) + this.Line4.GetHashCode();
                }
                if (this.StreetNumber != null)
                {
                    hashCode = (hashCode * 59) + this.StreetNumber.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.County != null)
                {
                    hashCode = (hashCode * 59) + this.County.GetHashCode();
                }
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.Salutation != null)
                {
                    hashCode = (hashCode * 59) + this.Salutation.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Fax != null)
                {
                    hashCode = (hashCode * 59) + this.Fax.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.RowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RowVersion.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
