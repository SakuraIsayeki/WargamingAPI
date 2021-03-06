﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WargamingAPI.WoT.Models.Accounts
{
    public class PublicAccountInfo
    {
        public Player player { get; set; }

        public int? clan_id { get; set; }

        public DateTime created_at { get; set; }

        public int global_rating { get; set; }

        public DateTime last_battle_time { get; set; }

        public DateTime logout_at { get; set; }

        public DateTime updated_at { get; set; }

        public bool Equals(PublicAccountInfo obj)
        {
            if (obj.created_at == created_at && player.Equals((object)obj.player))
            {
                return true;
            }
            return false;
        }
    }
}
