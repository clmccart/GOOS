using System;
using Matrix;
using Matrix.Xmpp;
using Matrix.Xmpp.Client;
using Matrix.Xmpp.MessageArchiving;

namespace Chapter10.Tests
{
    public class FakeAuctionServer
    {
        public const string ITEM_ID_AS_LOGIN = "auction-%s";
        public const string AUCTION_RESOURCE = "Auction";
        public const string XMPP_HOSTNAME = "localhost";
        private const string AUCTION_PASSWORD = "auction";

        private string itemId;
        private XmppClient connection;
        private Chat currentChat;

        public FakeAuctionServer(string itemId)
        {
            this.itemId = itemId;
            this.connection = new XmppClient(XMPP_HOSTNAME);
        }

        public void startSellingItem()
        {
            connection.SetUsername(ITEM_ID_AS_LOGIN);
            connection.Password = (AUCTION_PASSWORD);
            connection.SetResource(AUCTION_RESOURCE);
            //connection.SetXmppDomain()
            connection.Show = Show.Chat;
            // Trying to connect...if not send error message! 
            try {
                connection.Open();
                connection.OnLogin += new EventHandler<Matrix.EventArgs />(connection_OnLogin);
            }
            catch {
                XmppException xmppException = new XmppException();
                throw xmppException;
            }
        }

        public void hasReceivedJoinRequestFromSniper()
        {
            throw new NotImplementedException();
        }

        public void announceClosed()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
}