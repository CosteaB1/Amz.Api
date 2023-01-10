namespace Amz.Domain.Primitives
{
    //Many objects are not fundamentally defined by their attributes, but rather by a thread of continuity and identity (Eric Evans DDD)
    //continuity -> means that we need to be able to track an object through  the lifetime of our application
    //identity -> means we can uniquely identify each object in our system
    //An object primarily defined by its identity is called an Entity
    public abstract class Entity : IEquatable<Entity>  // to check what is IEquatable
    {
        protected Entity(Guid id)
        {
            Id = id;
        }
        // Once an entity is created and it has an Id assigned to it , we cannot change this id throught the lifetime of the entity's existance
        public Guid Id { get; private init; }

        public static bool operator ==(Entity? first, Entity? second)
        {
            return first is not null && second is not null && first.Equals(second);
        }

        public static bool operator !=(Entity? first, Entity? second)
        {
            return !(first == second);
        }

        // This method is from IEquatable
        public bool Equals(Entity? other)
        {
            if (other is null)
                return false;
            if (other.GetType() != GetType())
                return false;

            return other.Id == Id;
        }


        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            if (obj is not Entity entity)
                return false;
            return entity.Id == Id;
        }


        // this can be useful when we are creating a collection of entity types
        public override int GetHashCode()
        {
            return Id.GetHashCode() * 41;
        }
    }
}
