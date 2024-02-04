# batfileBootMin/batfileBootHide

## 概要
バッチファイルを最小化して、または非表示で実行します。  

**最小化して実行したい場合**  

1. `batfileBootMin.exe`をバッチファイルと同じ場所にコピーします。  
1. `batfileBootMin.exe`をバッチファイルと同じ名前（`aaa.bat`であれば`aaa.exe`）にします。  
1. `aaa.exe`を実行します。  

**非表示で実行したい場合**  

1. `batfileBootHide.exe`をバッチファイルと同じ場所にコピーします。  
1. `batfileBootHide.exe`をバッチファイルと同じ名前（`aaa.bat`であれば`aaa.exe`）にします。  
1. `aaa.exe`を実行します。  

**引数を利用する場合**  
ショートカットを例にして説明します。`batfileBootMin.exe`の場合で説明していますが、`batfileBootHide.exe`の場合でも同様です。

1. `batfileBootMin.exe`をバッチファイルと同じ場所にコピーします。  
1. `batfileBootMin.exe`をバッチファイルと同じ名前（`aaa.bat`であれば`aaa.exe`）にします。  
1. `aaa.exe`を右クリックして[ショートカットの作成]を選択します。  
1. 作成されたショートカットを右クリックして[プロパティ]を選択します。  
1. リンク先の最後に引数（例として`arg1 arg2`）を追加します。`C:\...\aaa.exe arg1 arg2`。  
1. ショートカットを実行します。  


## 動作確認環境
Microsoft Windows10 x64 + .NET Framework 4.8

## ライセンス

This software is released under the MIT License.  
詳細については、[LICENSE](./LICENSE) ファイルを参照してください。
