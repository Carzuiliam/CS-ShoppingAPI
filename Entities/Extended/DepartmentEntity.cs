using shopping_api.Entities.Default;
using Shopping_API.Entities.Attributes;

namespace shopping_api.Entities.Extended
{
    /// <summary>
    ///     Defines a custom entity, which represents the SQL object "Department" from the SQL
    /// database.
    /// </summary>
    public class DepartmentEntity : BaseEntity
    {
        /// <summary>
        ///     Contains the relations between the given <see cref="DepartmentEntity"/>
        /// entity and other entities.
        /// </summary>
        public DepartmentRelations Relations { get; set; }

        /// <summary>
        ///     Contains the filters of the given <see cref="DepartmentEntity"/>.
        /// </summary>
        public DepartmentFilters Filters { get; set; }

        /// <summary>
        ///     Contains the values for the given <see cref="DepartmentEntity"/>.
        /// </summary>
        public DepartmentValues Values { get; set; }

        /// <summary>
        ///     Creates a new <see cref="DepartmentEntity"/> object (an extension of
        /// the <see cref="BaseEntity"/> object).
        /// </summary>
        public DepartmentEntity() : base("TB_DEPARTMENT", "DPR_ID") 
        {
            Relations = new(this);
            Filters = new(this);
            Values = new(this);
        }

        /// <summary>
        ///     Defines an object that contains the relations between the <see cref="DepartmentEntity"/>
        /// and other entities.
        /// </summary>
        public class DepartmentRelations
        {
            /// <summary>
            ///     The parent <see cref="DepartmentEntity"/>.
            /// </summary>
            public DepartmentEntity Entity { set; get; }

            /// <summary>
            ///     Creates a new <see cref="DepartmentRelations"/> object.
            /// </summary>
            /// 
            /// <param name="_entity">The parent entity.</param>
            public DepartmentRelations(DepartmentEntity _entity)
            {
                Entity = _entity;
            }

            /// <summary>
            ///     Adds (binds) a entity to the given <see cref="DepartmentEntity"/>.
            /// </summary>
            /// 
            /// <param name="_entity">The entity to bind with the current entity.</param>
            /// <param name="_relationType">How the relation will be performed (full or optional).</param>
            public void Bind(BaseEntity _entity, EntityRelation.RelationMode _relationType)
            {
                Entity.AddEntityFilter(_entity, _relationType);
            }
        }

        /// <summary>
        ///     Contains a mapping between SQL attributes for the "Department" database object
        /// and the <see cref="DepartmentEntity"/> class, which is utilized to filter values
        /// from the same database object.
        /// </summary>
        public class DepartmentFilters
        {
            /// <summary>
            ///     The parent <see cref="DepartmentEntity"/>.
            /// </summary>
            public DepartmentEntity Entity { set; get; }

            ///     Internal fields of the class.
            private int _id = 0;
            private string _name = "";

            /// <summary>
            ///     Creates a new <see cref="DepartmentFilters"/> object.
            /// </summary>
            /// 
            /// <param name="_entity">The parent entity.</param>
            public DepartmentFilters(DepartmentEntity _entity)
            {
                Entity = _entity;
            }

            /// <summary>
            ///     A field that contains a filter for the corresponding <see cref="DepartmentEntity"/>
            /// attribute.
            /// </summary>
            public int Id
            {
                get => _id;
                set
                {
                    _id = value;
                    Entity.AddQueryFilter("DPR_ID", _id);
                }
            }

            /// <summary>
            ///     A field that contains a filter for the corresponding <see cref="DepartmentEntity"/>
            /// attribute.
            /// </summary>
            public string Name
            {
                get => _name;
                set
                {
                    _name = value;
                    Entity.AddQueryFilter("DPR_NAME", _name);
                }
            }
        }

        /// <summary>
        ///     Contains a mapping between SQL attributes for the "Department" database object
        /// and the <see cref="DepartmentEntity"/> class, utilized to set values to the attributes
        /// in the same database object.
        /// </summary>
        public class DepartmentValues
        {
            /// <summary>
            ///     The parent <see cref="DepartmentEntity"/>.
            /// </summary>
            public DepartmentEntity Entity { set; get; }

            ///     Internal fields of the class.
            private int _id = 0;
            private string _name = "";

            /// <summary>
            ///     Creates a new <see cref="DepartmentValues"/> object.
            /// </summary>
            /// 
            /// <param name="_entity">The parent entity.</param>
            public DepartmentValues(DepartmentEntity _entity)
            {
                Entity = _entity;
            }

            /// <summary>
            ///     A field that contains a new value for the corresponding <see cref="DepartmentEntity"/>
            /// attribute.
            /// </summary>
            public int Id
            {
                get => _id;
                set
                {
                    _id = value;
                    Entity.AddFieldValue("DPR_ID", _id);
                }
            }

            /// <summary>
            ///     A field that contains a new value for the corresponding <see cref="DepartmentEntity"/>
            /// attribute.
            /// </summary>
            public string Name
            {
                get => _name;
                set
                {
                    _name = value;
                    Entity.AddFieldValue("DPR_NAME", _name);
                }
            }
        }
    }
}
