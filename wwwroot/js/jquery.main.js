$(document).ready(function() {

	// tabs
	jQuery('.tabs .tab-links a').on('click', function(e) {
		var currentAttrValue = jQuery(this).attr('href');

		// Show/Hide Tabs
		jQuery('.tabs ' + currentAttrValue).show().siblings().hide();

		// Change/remove current tab to active
		jQuery(this).parent('li').addClass('active').siblings().removeClass('active');

		e.preventDefault();
	});

	// nice scroll
	$(".nicescroll-box").niceScroll(".wrap", {
		cursorcolor: "#5068B8",
		cursorwidth: "4px",
		autohidemode: false,
		easing: 'easeOutCircle',
		cursorborderradius: "4px"
	});

	// collapse
	$('.opener').on('click', function() {
		$('.slide-box').slideToggle(500);
		$('.info-inner').toggleClass('slide-open');
	});
});