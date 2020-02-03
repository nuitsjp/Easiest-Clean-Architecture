package jp.nuits.hatpepper.infrastructure.time

import jp.nuits.hatpepper.usecase.impl.TimeProvider
import org.threeten.bp.LocalDateTime

class TimeProviderImpl : TimeProvider {
    override fun now(): LocalDateTime {
        return LocalDateTime.now()
    }
}