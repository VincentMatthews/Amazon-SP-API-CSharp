/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// An additional set of seller inputs required to purchase shipping.
    /// </summary>
    [DataContract]
    public partial class AdditionalSellerInputs : IEquatable<AdditionalSellerInputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalSellerInputs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalSellerInputs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalSellerInputs" /> class.
        /// </summary>
        /// <param name="AdditionalInputFieldName">The name of the additional input field. (required).</param>
        /// <param name="AdditionalSellerInput">AdditionalSellerInput (required).</param>
        public AdditionalSellerInputs(string AdditionalInputFieldName = default(string), AdditionalSellerInput AdditionalSellerInput = default(AdditionalSellerInput))
        {
            // to ensure "AdditionalInputFieldName" is required (not null)
            if (AdditionalInputFieldName == null)
            {
                throw new InvalidDataException("AdditionalInputFieldName is a required property for AdditionalSellerInputs and cannot be null");
            }
            else
            {
                this.AdditionalInputFieldName = AdditionalInputFieldName;
            }
            // to ensure "AdditionalSellerInput" is required (not null)
            if (AdditionalSellerInput == null)
            {
                throw new InvalidDataException("AdditionalSellerInput is a required property for AdditionalSellerInputs and cannot be null");
            }
            else
            {
                this.AdditionalSellerInput = AdditionalSellerInput;
            }
        }

        /// <summary>
        /// The name of the additional input field.
        /// </summary>
        /// <value>The name of the additional input field.</value>
        [DataMember(Name = "AdditionalInputFieldName", EmitDefaultValue = false)]
        public string AdditionalInputFieldName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalSellerInput
        /// </summary>
        [DataMember(Name = "AdditionalSellerInput", EmitDefaultValue = false)]
        public AdditionalSellerInput AdditionalSellerInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalSellerInputs {\n");
            sb.Append("  AdditionalInputFieldName: ").Append(AdditionalInputFieldName).Append("\n");
            sb.Append("  AdditionalSellerInput: ").Append(AdditionalSellerInput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalSellerInputs);
        }

        /// <summary>
        /// Returns true if AdditionalSellerInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalSellerInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalSellerInputs input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdditionalInputFieldName == input.AdditionalInputFieldName ||
                    (this.AdditionalInputFieldName != null &&
                    this.AdditionalInputFieldName.Equals(input.AdditionalInputFieldName))
                ) &&
                (
                    this.AdditionalSellerInput == input.AdditionalSellerInput ||
                    (this.AdditionalSellerInput != null &&
                    this.AdditionalSellerInput.Equals(input.AdditionalSellerInput))
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
                if (this.AdditionalInputFieldName != null)
                    hashCode = hashCode * 59 + this.AdditionalInputFieldName.GetHashCode();
                if (this.AdditionalSellerInput != null)
                    hashCode = hashCode * 59 + this.AdditionalSellerInput.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}