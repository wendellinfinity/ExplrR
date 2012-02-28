using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;
using ExplrR.Models;
using System.Web.Script.Serialization;

namespace ExplrR {
    public class World : Hub {
        
        // 1. we changed our parameter now to "explorer"
        public void Explore(string explorer) {
            // 2. let us instantiate a JSON serializer to parse our JSON object
            var serializer = new JavaScriptSerializer();
            // 3. deserialize the JSON string, 'explorer' which was sent from the client
            var explorerInstance = serializer.Deserialize<Explorer>(explorer);
            // 4. let us manipulate some of the explorer instance properties, just an example
            explorerInstance.Location.X += 1;
            explorerInstance.Location.Y += 1;
            // 5. then we can send the serialized object to JSON string again to the client 'updateExplorer' handler
            Clients.updateExplorer(serializer.Serialize(explorerInstance));
        }

    }
}