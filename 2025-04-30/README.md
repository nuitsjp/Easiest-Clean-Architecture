# Android版

コンテンツは以下の通り。

- [PowerPointの原稿を文書化した記事](https://zenn.dev/nuits_jp/articles/2025-04-30-easiest-clean-architecture)
- [PowerPointファイル](https://raw.githubusercontent.com/nuitsjp/Easiest-Clean-Architecture/master/Android/Easiest-Clean-Architecture-for-Android.pptx)
- コード：非推奨コードとリファクタリング後のコード
    - [01.Before](01.Before)
    - [02.After](02.After)

## サンプルコードを実行するにあたって

ホットペッパー様のWeb APIを利用させていただいている関係上、実行するには事前に以下の対応を行う必要があります。

1. [APIキーの取得](https://webservice.recruit.co.jp/register/index.html)
2. APIキーの反映

### APIキーの反映について

HatPepper.Search.Bootstrapがスタートアッププロジェクトとなりますが、起動時の第一パラメーターとして渡してください。
