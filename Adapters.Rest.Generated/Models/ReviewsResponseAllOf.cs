/*
 * Review validation
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Adapters.Rest.Generated.Converters;

namespace Adapters.Rest.Generated.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ReviewsResponseAllOf : IEquatable<ReviewsResponseAllOf>
    {
        /// <summary>
        /// Gets or Sets Reviews
        /// </summary>
        [Required]
        [DataMember(Name="reviews", EmitDefaultValue=false)]
        public List<ReviewsModel> Reviews { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewsResponseAllOf {\n");
            sb.Append("  Reviews: ").Append(Reviews).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ReviewsResponseAllOf)obj);
        }

        /// <summary>
        /// Returns true if ReviewsResponseAllOf instances are equal
        /// </summary>
        /// <param name="other">Instance of ReviewsResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewsResponseAllOf other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Reviews == other.Reviews ||
                    Reviews != null &&
                    other.Reviews != null &&
                    Reviews.SequenceEqual(other.Reviews)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Reviews != null)
                    hashCode = hashCode * 59 + Reviews.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ReviewsResponseAllOf left, ReviewsResponseAllOf right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReviewsResponseAllOf left, ReviewsResponseAllOf right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
