package jp.nuits.hatpepper.presentation

import android.content.Context
import android.text.method.LinkMovementMethod
import android.util.AttributeSet
import android.widget.TextView
import androidx.core.text.HtmlCompat

class CreditView : TextView {
    constructor(context: Context) : this(context, null)

    constructor(context: Context, attrs: AttributeSet?) : super(context, attrs) {
        setCredit()
    }

    constructor(context: Context, attrs: AttributeSet?, defStyleAttr: Int) : super(context, attrs, defStyleAttr) {
        setCredit()
    }

    private fun setCredit()
    {
        this.text = HtmlCompat.fromHtml("Powered by <a href=\"http://webservice.recruit.co.jp/\">ホットペッパー Webサービス</a>", HtmlCompat.FROM_HTML_MODE_COMPACT)
        this.movementMethod = LinkMovementMethod.getInstance()
    }
}