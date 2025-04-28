using HatPepper.Search.Controller;
using HatPepper.Search.Gateway.Device;
using HatPepper.Search.Gateway.HotPepper;
using HatPepper.Search.UseCase;
using HatPepper.Search.View;

// このプログラムはコマンドライン引数でAPIキーを受け取り、
// HatPepperの検索および予約機能を統合的に実行します。
// 各レイヤーの依存関係を明示的に組み立てて、
// ユーザーからの入力に基づくレストラン予約処理を開始します。

if (args.Length == 0)
{
    // APIキーが指定されていない場合はエラーメッセージを表示して終了します。
    Console.WriteLine("APIキーを指定してください。");
    return;
}

// 検索サービスにAPIキーを設定します。
SearchService.ApiKey = args[0];

// 各コントローラーおよびユースケース、ゲートウェイ、ビューのインスタンスを生成し、
// アプリケーション全体のコントローラーを構築します。
var controller =
    new SearchController(
        new SearchRestaurantUseCase(
            new GeoCoordinator(),
            new SearchService()),
        new SearchRestaurantView());

// レストラン予約処理を非同期で開始します。
await controller.FindNearbyAsync();