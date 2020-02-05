package jp.nuits.hatpepper.infrastructure.time

import org.threeten.bp.LocalDateTime

class TimeProviderImpl : TimeProvider {
    override fun now(): LocalDateTime {
        return LocalDateTime.now()
    }
}