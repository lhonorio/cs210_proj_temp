// See https://aka.ms/new-console-template for more information

Board _board = new Board();

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirits of fear; but of power, and of love.",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Dalton",
        "Work hard to achieve your dreams. Don't let discouragement or mistakes delay.",
        new Source("How to dare great things",
        "google.com")
    )
);

_board.AddQuote(new Quote("Palpatine", "Execute order 66.", new Source("Palpatine", "starwars.com")));
_board.AddQuote(new Quote("Me", "I don't know", new Source("E, M", "me.com")));
_board.AddQuote(new Quote("Dumbledore", "Words are, in my not-so-humble opinion, our most inexhaustible source of magic. Capable of both inflicting injury, and remedying it", new Source("Dumbledore", "wizardingworld.com")));


// _board.GetRandomQuote();

Menu _menu = new Menu(_board);
_menu.Display();