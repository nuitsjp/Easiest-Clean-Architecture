package jp.nuits.hatpepper.usecase.impl

import org.threeten.bp.LocalDateTime

interface TimeProvider {
    fun now() : LocalDateTime
}