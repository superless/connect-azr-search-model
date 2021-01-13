﻿using Azure.Search.Documents.Indexes;
using Newtonsoft.Json;
using trifenix.connect.mdm.entity_model;

namespace trifenix.connect.mdm.search.model
{
    /// <summary>
    /// Clase base para las propiedades, 
    /// este incluye el índice que permitirá identificar la propiedad 
    /// y el valor que será determinado por quién herede o use la clase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseProperty<T> : IProperty<T>
    {

        /// <summary>
        /// índice de una propiedad, junto con el diccionario podrá identificar la propiedad. 
        /// </summary>
        [SimpleField(IsKey = false, IsFilterable = true)]
        [JsonProperty("index")]
        public int index { get; set; }


        /// <summary>
        /// valor que tendrá esa propiedad.
        /// el elemento T determina el tipo de valor,
        /// estos pueden ser bool, int, long, datetime, double, geo, etc.
        /// </summary>
        [SimpleField(IsKey = false, IsFilterable = true)]
        [JsonProperty("value")]
        public virtual T value { get; set; }
    }
}
