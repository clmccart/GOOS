using System;

namespace Chapter10.Tests
{
    public class FakeAuctionServer
    {
        private string v;

        public FakeAuctionServer(string v)
        {
            this.v = v;
        }

        public void startSellingItem()
        {
            throw new NotImplementedException();
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