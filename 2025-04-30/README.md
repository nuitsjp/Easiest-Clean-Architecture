# Android版

コンテンツは以下の通り。

- [PowerPointの原稿を文書化した記事](https://zenn.dev/nuits_jp/articles/2025-04-30-easiest-clean-architecture)
- [PowerPointファイル](https://view.officeapps.live.com/op/view.aspx?src=https%3A%2F%2Fraw.githubusercontent.com%2Fnuitsjp%2FEasiest-Clean-Architecture%2Frefs%2Fheads%2Fmaster%2F2025-04-30%2F%25E4%25B8%2596%25E7%2595%258C%25E4%25B8%2580%25E3%2582%258F%25E3%2581%258B%25E3%2582%258A%25E3%2582%2584%25E3%2581%2599%25E3%2581%2584Clean%2520Architecture%2520-%2520%25E6%258A%2580%25E8%25A1%2593%25E3%2583%25AC%25E3%2582%25A4%25E3%2583%25A4%25E3%2583%25BC%25E5%2588%2586%25E5%2589%25B2%25E3%2582%2588%25E3%2582%258A%25E5%25A4%25A7%25E5%2588%2587%25E3%2581%25AA%25E3%2583%25A2%25E3%2583%258E.pptx&wdOrigin=BROWSELINK)
- コード：非推奨コードとリファクタリング後のコード
    - [01.Before](01.Before)
    - [02.After](02.After)

## サンプルコードを実行するにあたって

ホットペッパー様のWeb APIを利用させていただいている関係上、実行するには事前に以下の対応を行う必要があります。

1. [APIキーの取得](https://webservice.recruit.co.jp/register/index.html)
2. APIキーの反映

### APIキーの反映について

HatPepper.Search.Bootstrapがスタートアッププロジェクトとなりますが、起動時の第一パラメーターとして渡してください。
