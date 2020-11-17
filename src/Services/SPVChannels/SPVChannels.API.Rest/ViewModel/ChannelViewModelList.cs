﻿using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace SPVChannels.API.Rest.ViewModel
{
  public class ChannelViewModelList
  {
    [JsonPropertyName("channels")]
    public ChannelViewModelGet[] Channels { get; set; }

    public ChannelViewModelList() { }

    public ChannelViewModelList(IEnumerable<ChannelViewModelGet> collecion)
    {
      Channels = collecion.ToArray();
    }
  }
}
