using System;
using System.Text.Json;

namespace GR
{
  public static class String
  {
    public static TValue Deserialize<TValue>(this string json,
      JsonSerializerOptions options = null)
    {
      if (options == null)
        options = new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip };
      return JsonSerializer.Deserialize<TValue>(json, options);
    }
  }
}
