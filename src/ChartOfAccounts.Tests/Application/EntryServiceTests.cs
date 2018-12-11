using ChartOfAccounts.Application;
using ChartOfAccounts.Domain;
using ChartOfAccounts.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ChartOfAccounts.Tests.Application
{
    public class EntryServiceTests : IDisposable
    {
        private readonly MockRepository mockRepository;
        private readonly Mock<IEntryRepository> mockEntryRepo;

        public EntryServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockEntryRepo = this.mockRepository.Create<IEntryRepository>();

        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private EntryService CreateService()
        {
            return new EntryService(mockEntryRepo.Object);
        }

        [Fact]
        public async Task PostEntryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateService();
            string number = "";
            DateTimeOffset date = DateTime.Now;
            List<EntryItem> items = new List<EntryItem>();

            // Act
            var result = await unitUnderTest.PostEntryAsync(
                number,
                date,
                items);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RetrieveEntryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateService();
            string number = "23423423423";

            // Act
            var entry = await unitUnderTest.RetrieveEntryAsync(
                number);
            

            // Assert
            Assert.True(false);
        }
        
        [Fact]
        public async Task ApplyAsync_StateUnderTest()
        {
            // Arrange
            var unitUnderTest = this.CreateService();
            string number = "23423423423";

            // Act
            var entry = await unitUnderTest.RetrieveEntryAsync(
                number);


            entry.AddItem(new EntryItem());


            await unitUnderTest.Save(entry);

            // Assert
            Assert.True(false);
        }
    }
}
