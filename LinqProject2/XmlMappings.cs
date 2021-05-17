/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml;

namespace Xml2CSharp
{
    [XmlRoot(ElementName = "player")]
    public class Player
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "number")]
        public string Number { get; set; }
        [XmlElement(ElementName = "nickname")]
        public string Nickname { get; set; }
        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        [XmlIgnore]
        public bool Paid { get; set; }

        [XmlElement(ElementName = "paid")]
        public string PaidUp
        {
            get { return this.Paid ? "TRUE" : "FALSE"; }
            set { this.Paid = XmlConvert.ToBoolean(value.ToLower()); } 
        }
    }

    [XmlRoot(ElementName = "Players")]
    public class Players
    {
        [XmlElement(ElementName = "player")]
        public List<Player> Player { get; set; }
    }

    [XmlRoot(ElementName = "Pokemon")]
    public class Pokemon
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "attack")]
        public string Attack { get; set; }
        [XmlElement(ElementName = "defense")]
        public string Defense { get; set; }
    }

    [XmlRoot(ElementName = "PokemonTypes")]
    public class PokemonTypes
    {
        [XmlElement(ElementName = "Pokemon")]
        public List<Pokemon> Pokemon { get; set; }
    }

    [XmlRoot(ElementName = "Ownership")]
    public class Ownership
    {
        [XmlElement(ElementName = "player")]
        public string Player { get; set; }
        [XmlElement(ElementName = "pokemonId")]
        public string PokemonId { get; set; }
        [XmlElement(ElementName = "level")]
        public string Level { get; set; }
        [XmlElement(ElementName = "numberOwned")]
        public string NumberOwned { get; set; }
    }

    [XmlRoot(ElementName = "OwnershipData")]
    public class OwnershipData
    {
        [XmlElement(ElementName = "Ownership")]
        public List<Ownership> Ownership { get; set; }
    }

    [XmlRoot(ElementName = "Pokedata")]
    public class Pokedata
    {
        [XmlElement(ElementName = "Players")]
        public Players Players { get; set; }
        [XmlElement(ElementName = "PokemonTypes")]
        public PokemonTypes PokemonTypes { get; set; }
        [XmlElement(ElementName = "OwnershipData")]
        public OwnershipData OwnershipData { get; set; }
    }

}
