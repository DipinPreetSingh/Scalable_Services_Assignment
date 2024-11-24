package com.ecommerce.shipping.service;

import com.ecommerce.shipping.entity.Shipment;
import com.ecommerce.shipping.entity.ShippingOption;
import com.ecommerce.shipping.repository.ShipmentRepository;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Service
public class ShippingService {
    private final ShipmentRepository repository;

    public ShippingService(ShipmentRepository repository) {
        this.repository = repository;
    }

    public List<ShippingOption> getShippingOptions(String destination) {
        List<ShippingOption> options = new ArrayList<>();
        options.add(new ShippingOption("Standard", 5.0, 5));
        options.add(new ShippingOption("Express", 15.0, 2));
        options.add(new ShippingOption("Same-Day", 25.0, 0));
        return options;
    }

    public Shipment createShipment(String orderId, String carrier, LocalDateTime estimatedDelivery) {
        Shipment shipment = new Shipment();
        shipment.setOrderId(orderId);
        shipment.setStatus("Pending");
        shipment.setCarrier(carrier);
        shipment.setEstimatedDelivery(estimatedDelivery);
        return repository.save(shipment);
    }

    public Optional<Shipment> trackShipment(String orderId) {
        return repository.findByOrderId(orderId);
    }
}
