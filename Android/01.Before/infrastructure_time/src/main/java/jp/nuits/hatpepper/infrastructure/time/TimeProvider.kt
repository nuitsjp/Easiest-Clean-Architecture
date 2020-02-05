package jp.nuits.hatpepper.infrastructure.time

import org.threeten.bp.LocalDateTime

interface TimeProvider {
    fun now() : LocalDateTime
}