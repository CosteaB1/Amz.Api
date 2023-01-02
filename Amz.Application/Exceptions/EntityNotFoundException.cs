namespace Amz.Application.Exceptions
{
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(Type entityType, Guid id) : base($"Entity of type {entityType.Name} with id: {id} not found")
        {
        }
        public static EntityNotFoundException OfType<T>(Guid withId)
        {
            return new EntityNotFoundException(typeof(T), withId);
        }
    }
}
