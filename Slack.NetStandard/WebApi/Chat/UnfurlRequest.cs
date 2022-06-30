﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Slack.NetStandard.Messages;
using Slack.NetStandard.Messages.Blocks;
using System.Linq;

namespace Slack.NetStandard.WebApi.Chat
{
    public class UnfurlRequest
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("ts")]
        public string Timestamp { get; set; }

        [JsonProperty("unfurls")]
        public Dictionary<string,Attachment> Unfurls { get; set; }

        [JsonProperty("user_auth_blocks", NullValueHandling = NullValueHandling.Ignore)]
        public IList<IMessageBlock> UserAuthBlocks { get; set; } = new List<IMessageBlock>();

        [JsonProperty("user_auth_message",NullValueHandling = NullValueHandling.Ignore)]
        public string UserAuthMessage { get; set; }

        [JsonProperty("user_auth_required",NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserAuthRequired { get; set; }

        [JsonProperty("user_auth_url",NullValueHandling = NullValueHandling.Ignore)]
        public string UserAuthUrl { get; set; }

        public bool ShouldSerializeUserAuthBlocks() => UserAuthBlocks?.Any() ?? false;
    }
}
