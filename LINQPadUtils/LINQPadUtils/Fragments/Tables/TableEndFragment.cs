namespace LINQPadUtils.Fragments
{
    using LINQPadUtils.MetadataProviders;

    class TableEndFragment : FragmentBase
    {
        public TableEndFragment(TypeMetadataProviderBase metadata)
            : base(metadata)
        {
        }

        public override string Render(int depthLimit, int currentDepth)
        {
            if (base.Metadata.IsEnumerable)
            {
                return LinqPadUtilResources.EnumerableResultTableFoot;
            }

            return LinqPadUtilResources.ObjectResultTableFoot;
        }
    }
}