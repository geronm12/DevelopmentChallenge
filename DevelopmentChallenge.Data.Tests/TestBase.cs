namespace DevelopmentChallenge.Data.Tests
{
    public class TestBase
    {
        protected IMessage _messageService;

        public TestBase()
        {
            _messageService = new Message();
        }
    }
}
