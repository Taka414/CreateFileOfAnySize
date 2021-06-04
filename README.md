# CreateFileOfAnySize

This is a tool to create files of any size.

任意のサイズのファイルを作成するツールです。

"FileCreator.exe" を起動し、以下の画面から生成を作成します。

![image](README.md.resources/01.PNG)

作成されるファイルはZip圧縮しても1バイトも圧縮できないファイルになります。

これは、ファイルを生成するための DummyFileUtil クラス内の各メソッドにあるcomplexityを1に近づけることで調整できます。