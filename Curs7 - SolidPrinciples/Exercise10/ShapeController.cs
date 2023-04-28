namespace Exercise10
{
    internal class ShapeController  //
    {
        private IShape _shape;

        public ShapeController(IShape shape)
        {
            _shape = shape;
        }
    }
}
