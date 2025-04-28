using HatPepper.Controller;
using HatPepper.Reservation.Application;
using HatPepper.Reservation.Presentation.View;

namespace HatPepper.Reservation.Presentation.Controller;

/// <summary>
/// レストラン予約処理を担当するコントローラーです。
/// ユースケースおよびビューを連携させ、ユーザー入力に基づく予約フローを制御します。
/// </summary>
public class ReservationController(
    IReservationUseCase reservationUseCase,
    IReservationView reservationView) : IReservationController
{
    /// <summary>
    /// 指定したレストランIDに対して予約処理を非同期で実行します。
    /// ユーザーから人数・時間帯を入力させ、予約ユースケースを呼び出します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    public async Task ReserveAsync(RestaurantId restaurantId)
    {
        // ユーザーから予約人数を入力として受け取ります。
        var partySize = reservationView.InputPartySize();

        // 指定レストラン・本日・人数に対する予約可能な時間帯を取得します。
        var timeSlots = await reservationUseCase
            .GetAvailableTimeSlotsAsync(restaurantId, Date.Today, partySize)
            .ToListAsync();

        // 取得した時間帯からユーザーに選択させます。
        var timeSlot = reservationView.SelectTimeSlot(timeSlots);

        // 選択された時間帯・人数で予約処理を実行します。
        await reservationUseCase.ReserveAsync(restaurantId, timeSlot, partySize);

        // 予約完了をユーザーに通知します。
        reservationView.NotifySuccess();
    }
}