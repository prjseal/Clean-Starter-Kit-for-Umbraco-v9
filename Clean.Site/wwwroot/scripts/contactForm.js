var contactForm = contactForm || {
    init: function () {
        this.listeners();
    },
    listeners: function () {
        $(document).on('click', '.contact-submit', function (e) {
            e.preventDefault();
            var form = $('#contact-form');
            form.submit();
        })
    },
    showResult: function () {
        $("#form-outer").hide('slow');
        $("#article-content").hide('slow');
        $("#form-result").show('slow');
        $("pre").each(function() {
            $(this).addClass("prettyprint");
            PR.prettyPrint();
        });
    }
};

contactForm.init();