using System;
using NBAPlayerStatsAPI.Services;
using NBAPlayerStatsAPI.Models;

namespace NBAPlayerStatsAPITests
{
	public class NBAPlayerStatsAPITest
	{
		[Fact]
		public void Get_Player_by_Name_when_Player_Exists()
		{
            // Arrange
            var service = new PlayerService(); // will fail until you implement this class

            // Act
            var result = service.GetPlayerByName("LeBron James");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("LeBron James", result.FirstName);
        }
	}
}

