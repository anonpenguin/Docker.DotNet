using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class ImageHistoryResponse // (types.ImageHistory)
    {
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string ID { get; set; }

        [DataMember(Name = "Created", EmitDefaultValue = false)]
        public long Created { get; set; }

        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        [DataMember(Name = "Tags", EmitDefaultValue = false)]
        public IList<string> Tags { get; set; }

        [DataMember(Name = "Size", EmitDefaultValue = false)]
        public long Size { get; set; }

        [DataMember(Name = "Comment", EmitDefaultValue = false)]
        public string Comment { get; set; }
    }
}
