using Design_pattern;

ProductBuilder productBuilder = new();
var pizza = productBuilder.SetPrice(2)
    .SetName("margarita");

Console.WriteLine(pizza);
/*
 * Bu nümunədə, Builder design pattern-i bir pizza obyektinin yaradılmasına tətbiq etdik.
 * Bu yolla, müxtəlif xüsusiyyətləri bir araya gətirmək və daha oxşar obyektlərin yaradılmasını sürətləndirmək üçün
 * bir yol təqdim edirik.
 * */