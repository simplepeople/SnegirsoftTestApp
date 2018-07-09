﻿using System;
using Newtonsoft.Json;

namespace DepartmentList.Models
{
    public class DepartmentDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("hasChildren")]
        public bool HasChildDepartments { get; set; }
        [JsonProperty("parentId")]
        public int? ParentId { get; set; }
    }
}