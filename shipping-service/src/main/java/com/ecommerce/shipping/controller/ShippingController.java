package com.ecommerce.shipping.controller;

import com.ecommerce.shipping.entity.Shipment;
import com.ecommerce.shipping.entity.ShippingOption;
import com.ecommerce.shipping.service.ShippingService;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/shipping")
public class ShippingController {
    private final ShippingService service;

    public ShippingController(ShippingService service) {
        this.service = service;
    }

    @GetMapping("/options")
    public ResponseEntity<List<ShippingOption>> getShippingOptions(@RequestParam String destination) {
        return ResponseEntity.ok(service.getShippingOptions(destination));
    }

    @PostMapping("/create")
    public ResponseEntity<Shipment> createShipment(@RequestParam String orderId,
                                                   @RequestParam String carrier,
                                                   @RequestParam int estimatedDays) {
        Shipment shipment = service.createShipment(orderId, carrier, LocalDateTime.now().plusDays(estimatedDays));
        return ResponseEntity.ok(shipment);
    }

    @GetMapping("/track/{orderId}")
    public ResponseEntity<Shipment> trackShipment(@PathVariable String orderId) {
        Optional<Shipment> shipment = service.trackShipment(orderId);
        return shipment.map(ResponseEntity::ok).orElseGet(() -> ResponseEntity.notFound().build());
    }
}
