int pictureInAlbum = 52;
int pictureRemains;
int pictureInScreen;
int pictureRow = 3;

pictureInScreen = pictureInAlbum / pictureRow;
pictureRemains = pictureInAlbum % pictureRow;

Console.WriteLine($"Столько рядов будет заполнено полностью {pictureInScreen}");
Console.WriteLine($"Остаток - {pictureRemains}");