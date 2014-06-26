var domModule = (function () {
    var buffer = [];

    function appendChild(element, parentSelector) {
        var parent = document.querySelector(parentSelector);
        parent.appendChild(element);
    }

    function removeChild(parentSelector, childSelector) {
        var parent = document.querySelector(parentSelector);
        var element = document.querySelector(childSelector);
        parent.removeChild(element);
    }

    function addHandler(elementSelector, eventType, eventHandler) {
        var element = document.querySelector(elementSelector);
        element.addEventListener(eventType, eventHandler);
    }

    function appendToBuffer(parentSelector, element) {
        if (buffer[parentSelector]) {
            buffer[parentSelector].push(element);

            if (buffer[parentSelector].length == 100) {
                var frag = document.createDocumentFragment();
                for (var i = 0; i < buffer[parentSelector].length; i++) {
                    frag.appendChild(buffer[parentSelector][i]);
                }

                var parent = document.querySelector(parentSelector);
                parent.appendChild(frag);

                buffer[parentSelector] = [];
            }

        } else {
            buffer[parentSelector] = [];
            buffer[parentSelector].push(element);
        }
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer
    };

})();
