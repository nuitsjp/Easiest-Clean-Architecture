# Android版

コンテンツは以下の通り。

- [PowerPointの原稿を文書化した記事](https://www.nuits.jp/entry/easiest-clean-architecture-2019-09)
- [PowerPointファイル](Easiest-Clean-Architecture-for-Android.pptx)
- コード：非推奨コードとリファクタリング後のコード
    - [01.Before](01.Before)
    - [02.After](02.After)

## サンプルコードを実行するにあたって

ホットペッパー様のWeb APIを利用させていただいている関係上、実行するには事前に以下の対応を行う必要があります。

1. [APIキーの取得](https://webservice.recruit.co.jp/register/index.html)
2. APIキーの反映

### APIキーの反映について

infrastructure_apiモジュール内のjp.nuits.hatpepper.infrastructure.api.Secretsへ、取得したキーを適用してください。
