using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Sdl.Community.GroupShareKit.Clients;

namespace Sdl.Community.GroupShareKit.Models.Response.TranslationMemory
{
    [DataContract]
   public class Children
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }

        [DataMember(Name = "tokens")]
        public List<Token> Tokens { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        
        [DataMember(Name= "children")]
        public List<Children> ChildList { get; set; }
    }
}
