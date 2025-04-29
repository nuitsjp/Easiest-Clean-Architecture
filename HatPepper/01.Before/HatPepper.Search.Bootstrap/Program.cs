using HatPepper.Search.Gateway.HotPepper;
using HatPepper.Search.Presentation.Controller;

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
GourmetSearchApi.ApiKey = args[0];

// コントローラーを構築します。
var controller = new SearchRestaurantController();

// 近隣の店舗を検索し、結果を表示します。
await controller.FindNearbyAsync();