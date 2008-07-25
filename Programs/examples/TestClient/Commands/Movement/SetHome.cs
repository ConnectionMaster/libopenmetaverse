using System;
using System.Collections.Generic;
using System.Text;
using OpenMetaverse;
using OpenMetaverse.Packets;

namespace OpenMetaverse.TestClient
{
    public class SetHomeCommand : Command
    {
		public SetHomeCommand(TestClient testClient)
        {
            Name = "sethome";
            Description = "Sets home to the current location.";
        }

        public override string Execute(string[] args, UUID fromAgentID)
        {
			Client.Self.SetHome();
            return "Home Set";
        }
    }
}
