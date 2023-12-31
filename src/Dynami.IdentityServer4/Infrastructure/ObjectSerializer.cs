﻿
using System.Text.Json;

namespace Dynami.IdentityServer4
{
    internal static class ObjectSerializer
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            IgnoreNullValues = true
        };
        
        public static string ToString(object o)
        {
            return JsonSerializer.Serialize(o, Options);
        }

        public static T FromString<T>(string value)
        {
            return JsonSerializer.Deserialize<T>(value, Options);
        }
    }
}