namespace sample1.Models
{
    #region for singleton

    public interface ISingleTonUtility
    {
        public int GetTheCount();
    }

    public class SingleTonUtility : ISingleTonUtility
    {

        public int SingId { get; set; }

        public int GetTheCount()
        {
            SingId = SingId + 1;

            return SingId;
        }
    }

    #endregion


    #region for scoped

    public interface IScopedTonUtility
    {
        public int GetScopedTheCount();
    }

    public class ScopedTonUtility : IScopedTonUtility
    {

        public int ScopeId { get; set; }

        public int GetScopedTheCount()
        {
            ScopeId = ScopeId + 1;

            return ScopeId;
        }
    }

    #endregion






    #region for transient

    public interface ITransientUtility
    {
        public int GetTransientTheCount();
    }

    public class TransientUtility : ITransientUtility
    {

        public int TransientId { get; set; }

        public int GetTransientTheCount()
        {
            TransientId = TransientId + 1;

            return TransientId;
        }
    }

    #endregion




}
