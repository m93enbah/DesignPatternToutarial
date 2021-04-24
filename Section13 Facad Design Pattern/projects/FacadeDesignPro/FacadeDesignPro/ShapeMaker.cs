namespace FacadeDesignPro
{
    //we see that on the ShapeMaker class we declare the instance of each terminal class by provide the type of the interface
    //so the facade design pattern hides the complexity system by provide you the ShapeMaker class only
    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }
}
