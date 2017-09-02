// From: https://government.github.com/assets/js/home.js
(function () {
	(function ($) {
		var $animateIn, $animateOut, animateInOffset, animateOutOffset;
		$animateIn = $('.animate-in');
		$animateOut = $('.animate-out');
		animateInOffset = 50;
		animateOutOffset = 100;
		$animateIn.addClass('pre-animate');
		$animateOut.addClass('pre-animate-out');
		var onScroll = function (e) {
			var bottomScrollPosition, windowHeight, windowScrollPosition;
			windowHeight = $(window).height();
			windowScrollPosition = $(window).scrollTop();
			bottomScrollPosition = windowHeight + windowScrollPosition;
			$animateIn.each(function (i, element) {
				if ($(element).offset().top + animateInOffset < bottomScrollPosition) {
					return $(element).removeClass('pre-animate');
				}
			});
			return $animateOut.each(function (i, element) {
				if ($(element).offset().top + animateOutOffset < bottomScrollPosition) {
					return $(element).removeClass('pre-animate-out');
				}
			});
		};
		onScroll();
		return $(window).scroll(onScroll);
	})(jQuery);
}).call(this);
