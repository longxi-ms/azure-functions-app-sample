import logging

import azure.functions as func


def main(req: func.HttpRequest) -> func.HttpResponse:
    logging.warning('WARNING: Python HTTP trigger function processed a request.')

    test_str = 'This is a test string, designed to induce some random exceptions.'

    logging.info(test_str['df'])

    name = req.params.get('name')
    if not name:
        try:
            req_body = req.get_json()
        except ValueError:
            pass
        else:
            name = req_body.get('name')

    if name:
        return func.HttpResponse(f"Hello, {name}. This HTTP triggered function executed successfully.")
    else:
        return func.HttpResponse(
             "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response.",
             status_code=200
        )
