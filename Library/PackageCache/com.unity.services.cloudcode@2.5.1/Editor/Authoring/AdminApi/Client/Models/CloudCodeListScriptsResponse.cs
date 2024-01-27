//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CloudCode.Authoring.Client.Http;



namespace Unity.Services.CloudCode.Authoring.Client.Models
{
    /// <summary>
    /// CloudCodeListScriptsResponse model
    /// </summary>
    [Preserve]
    [DataContract(Name = "cloud_code_list_scripts_response")]
    internal class CloudCodeListScriptsResponse
    {
        /// <summary>
        /// Creates an instance of CloudCodeListScriptsResponse.
        /// </summary>
        /// <param name="total">Total number of Scripts</param>
        /// <param name="offset">Offset used by the request</param>
        /// <param name="limit">Limit used by the request</param>
        /// <param name="results">List of Scripts</param>
        [Preserve]
        public CloudCodeListScriptsResponse(int total = default, int offset = default, int limit = default, List<CloudCodeListScriptsResponseResultsInner> results = default)
        {
            Total = total;
            Offset = offset;
            Limit = limit;
            Results = results;
        }

        /// <summary>
        /// Total number of Scripts
        /// </summary>
        [Preserve]
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total{ get; }
        
        /// <summary>
        /// Offset used by the request
        /// </summary>
        [Preserve]
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset{ get; }
        
        /// <summary>
        /// Limit used by the request
        /// </summary>
        [Preserve]
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit{ get; }
        
        /// <summary>
        /// List of Scripts
        /// </summary>
        [Preserve]
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<CloudCodeListScriptsResponseResultsInner> Results{ get; }
    
        /// <summary>
        /// Formats a CloudCodeListScriptsResponse into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "total," + Total.ToString() + ",";
            serializedModel += "offset," + Offset.ToString() + ",";
            serializedModel += "limit," + Limit.ToString() + ",";
            if (Results != null)
            {
                serializedModel += "results," + Results.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CloudCodeListScriptsResponse as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var totalStringValue = Total.ToString();
            dictionary.Add("total", totalStringValue);
            
            var offsetStringValue = Offset.ToString();
            dictionary.Add("offset", offsetStringValue);
            
            var limitStringValue = Limit.ToString();
            dictionary.Add("limit", limitStringValue);
            
            return dictionary;
        }
    }
}