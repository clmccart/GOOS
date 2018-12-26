using System;
using Xunit;

namespace Chapter10.Tests
{
    public class AuctionSniperTests
    {
        public static FakeAuctionServer auction = new FakeAuctionServer("item-54321");
        public static ApplicationRunner application = new ApplicationRunner();
        [Fact]
        public void AuctionSniper_JoinsAuction_UntilAuctionCloses()
        {
            auction.startSellingItem();
            application.startBiddingIn(auction);
            auction.hasReceivedJoinRequestFromSniper();
            auction.announceClosed();
            application.showsSniperHasLostAuction();

            auction.stop();
            application.stop();
        }
    }
}
